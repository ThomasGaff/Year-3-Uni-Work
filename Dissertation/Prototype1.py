# Convolutional Neural Network Prototype 1, Character Recognition
import numpy
from keras.datasets import mnist
from keras.models import Sequential
from keras.layers import Dense
from keras.layers import Dropout
from keras.layers import Flatten
from keras.layers.convolutional import Conv2D
from keras.layers.convolutional import MaxPooling2D
from keras.utils import np_utils
from keras import backend as K
from keras.models import load_model
K.set_image_dim_ordering('th')

# The code from lines 15-33 is used from https://machinelearningmastery.com/handwritten-digit-recognition-using-convolutional-neural-networks-python-keras/
# Fix the random seed for to allow for reproducibility
numpy.random.seed(8)

# Load the mnist dataset
(X_train, y_train), (X_test, y_test) = mnist.load_data()

# Reshape the data to be in the format of [samples][pixels][width][height]
X_train = X_train.reshape(X_train.shape[0], 1, 28, 28).astype('float32')
X_test = X_test.reshape(X_test.shape[0], 1, 28, 28).astype('float32')

# Normalize the inputs from 0-255 to 0-1
X_train = X_train / 255
X_test = X_test / 255

# One hot encode outputs
y_train = np_utils.to_categorical(y_train)
y_test = np_utils.to_categorical(y_test)
num_classes = y_test.shape[1]

# The code on lines 37-54 is my own code, but inspired by https://machinelearningmastery.com/handwritten-digit-recognition-using-convolutional-neural-networks-python-keras/
# Define the CNN
def Prototype_1():

    # create model
    model = Sequential()
    model.add(Conv2D(50, (3, 3), input_shape=(1, 28, 28), activation='relu'))
    model.add(MaxPooling2D(pool_size=(2, 2)))
    model.add(Conv2D(40, (3, 3), activation='relu'))
    model.add(MaxPooling2D(pool_size=(2, 2)))
    model.add(Dropout(0.2))
    model.add(Flatten())
    model.add(Dense(300, activation='relu'))
    model.add(Dropout (0.2))
    model.add(Dense(150, activation='relu'))
    model.add(Dense(num_classes, activation='softmax'))

    # Compile model
    model.compile(loss='categorical_crossentropy', optimizer='adam', metrics=['accuracy'])
    return model

# The code on lines 58-71 is a mixture of my code, Keras libary code and code from https://machinelearningmastery.com/handwritten-digit-recognition-using-convolutional-neural-networks-python-keras/
# Build the model
model = Prototype_1()

# Load the model
model = load_model('Prototype_1.1.h5')

# Fit the model
model.fit(X_train, y_train, validation_data=(X_test, y_test), epochs=1, batch_size=100)

# Save the model
model.save('Prototype_1.1.h5')

# Final evaluation of the model
scores = model.evaluate(X_test, y_test, verbose=0)
print("Prototype 1 Error Rate: %.2f%%" % (100-scores[1]*100))