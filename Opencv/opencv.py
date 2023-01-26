import cv2

img = cv2.imread("test.png")
print(img.shape)
img = cv2.resize(img, (10000, 10000))
print(img.shape)
cv2.imshow("Result", img)

cv2.waitKey(0)