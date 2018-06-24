# import the necessary packages
from PIL import Image
import pytesseract
import numpy
import cv2
import os

#The code is inspired by and uses some of the code found here https://www.pyimagesearch.com/2017/07/10/using-tesseract-ocr-python/
#The code from lines 11-25 and 34-36 is from the OpenCV libary
#Import image
image = cv2.imread('PrintedHW.jpg')

# Greyscale
grey = cv2.cvtColor(image,cv2.COLOR_BGR2GRAY)

# Binary
ret,thresh = cv2.threshold(grey,127,255,cv2.THRESH_BINARY_INV)

# Smooth the image to avoid noises
gray = cv2.medianBlur(grey,5)

# write the grayscale image to disk as a temporary file so we can
# apply OCR to it
filename = "{}.png".format(os.getpid())
cv2.imwrite(filename, grey)

# The code on line 28 is from the PyTesseract library
# Load the image as a PIL/Pillow image, apply OCR, and then delete the temporary file
text = pytesseract.image_to_string(Image.open(filename))
os.remove(filename)
print(text)

# show the output images
cv2.imshow("Image", image)
cv2.imshow("Output", grey)
cv2.waitKey(0)