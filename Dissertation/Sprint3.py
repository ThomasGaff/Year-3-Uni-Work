# import the necessary packages
from PIL import Image
import numpy
import pytesseract
import cv2
import os

# Code on lines 11-52 and 60-66 uses OpenCv library The code on lines 14-20 uses some pre-processing code found here https://www.pyimagesearch.com/2017/07/10/using-tesseract-ocr-python/

# Import Image
image = cv2.imread('example_01.png')

# Greyscale
grey = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)

# Binary
ret,thresh = cv2.threshold(grey,127,255,cv2.THRESH_BINARY_INV)

# Use blur to reduce noise
grey = cv2.medianBlur(grey, 3)

cv2.imshow( 'grey', grey)


kernel = numpy.ones((5,100), numpy.uint8)
img_dilation = cv2.dilate(thresh, kernel, iterations=1)
thresh = cv2.erode(thresh,None,iterations = 2)

im2,contours, hierarchy = cv2.findContours(img_dilation.copy(), cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)


sorted_contours = sorted(contours, key=lambda contour: cv2.boundingRect(contour)[0])
# Code on lines 34-39 and lines 58-62 were used from https://stackoverflow.com/questions/46282691/opencv-cropping-handwritten-lines-line-segmentation
for i, contours in enumerate(sorted_contours):
    # Get bounding box
    x, y, w, h = cv2.boundingRect(contours)

    # Getting ROI
    roi = image[y:y+h, x:x+w]

    cv2.imwrite("roi.png", roi)

    # Apply more pre-processing the the ROI
    roiimage = cv2.imread('roi.png')
    grey = cv2.cvtColor(roiimage, cv2.COLOR_BGR2GRAY)

    grey = cv2.threshold(grey, 0, 255, cv2.THRESH_BINARY | cv2.THRESH_OTSU)[1]

    grey = cv2.medianBlur(grey, 3)

    cv2.imwrite("roi.png", grey)

    cv2.imshow('roi gray', grey)
# Line 54 uses the PyTesseract Library
    text = pytesseract.image_to_string(Image.open('roi.png'))

    if text :
        print('Segment no ' + str(i) + ' : ' + text)

    # Show ROI
    cv2.imshow('segment no:'+str(i),roi)
    cv2.rectangle(image,(x,y),( x + w, y + h ),(90,0,255),2)


cv2.imshow('marked areas',image)

print ('Finished OCR')
cv2.waitKey(0)