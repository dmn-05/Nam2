# # 1. Tạo một dictionary đơn giản chứa thông tin về tên và tuổi của bạn.
# dictionnary = {
#     'name': "Nhat",
#     'age' : 19
# }
# dic= {}
# # 2. Truy xuất và in ra giá trị tuổi từ dictionary đã tạo.
# print(dictionnary['age'])
# # 3. Thêm một thông tin về trường học.
# dictionnary['school'] = "CKC"
# # 4. Hãy cộng thêm một tuổi.
# dictionnary['age']+=1
# # 5. Xóa tuổi.
# # dictionnary.pop('age')
# # 6. Sử dụng vòng lặp để in ra tất cả các key và value trong dictionary.
# for i in dictionnary:
#     print(i)
#     print(dictionnary[i])

# # 7. Sao chép nội dung của một dictionary sang một dictionary khác.
# dic = dictionnary.copy()
# for i in dictionnary:
#     print(i)
#     print(dictionnary[i])
# # 8. Thêm thông tin về địa chỉ là một dictionary gồm tỉnh, huyện, xã.
# dictionnary['Xa'] = "Tan Loi"
# dictionnary['Huyen'] = "Hon Quan"
# dictionnary['Tinh'] = "Binh Phuoc"
# print(dictionnary)
# # 9. Hãy in ra thông tin về tỉnh.
# print(dictionnary['Tinh'])
# # 10. Tạo một dictionary chứa bình phương của các số từ 1 đến 5.

l = [1,2,3,4]
print(l[::-1])