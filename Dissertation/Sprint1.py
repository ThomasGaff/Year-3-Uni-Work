import cv2
import numpy
from keras import backend as K
K.set_image_dim_ordering('th')

# The entire code uses the OpenCV library
# The code on lines 12-18 uses some pre-processing code found here https://www.pyimagesearch.com/2017/07/10/using-tesseract-ocr-python/
# Import image
image = cv2.imread('PrintedHW.jpg')

# Greyscale
grey = cv2.cvtColor(image,cv2.COLOR_BGR2GRAY)

# Binary
ret,thresh = cv2.threshold(grey,127,255,cv2.THRESH_BINARY_INV)

# smooth the image to avoid noises
grey = cv2.medianBlur(grey,5)


# Dilation
kernel = numpy.ones((5,100), numpy.uint8)
img_dilation = cv2.dilate(thresh, kernel, iterations=1)
thresh = cv2.erode(thresh,None,iterations = 2)

# Find contours
im2,contours, hierarchy = cv2.findContours(img_dilation.copy(), cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)

# Sort contours
sorted_contours = sorted(contours, key=lambda contour: cv2.boundingRect(contour)[0])

# Code on lines 33-42 were used from https://stackoverflow.com/questions/46282691/opencv-cropping-handwritten-lines-line-segmentation
for i, contour in enumerate(sorted_contours):
    # Get bounding box
    x, y, w, h = cv2.boundingRect(contour)

    # Get ROI
    roi = image[y:y+h, x:x+w]

    # Show ROI
    cv2.imshow('segment no:'+str(i),roi)
    cv2.rectangle(image,(x,y),( x + w, y + h ),(90,0,255),2)

cv2.imshow('marked areas',image)
cv2.waitKey(0)