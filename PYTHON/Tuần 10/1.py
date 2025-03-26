import string
import re
from collections import Counter
txt = """University is the place where students get knowledge and new experiences. Studying in university gives a vast exposure to the student in his specified field. University builds a professional base in the student.
Till their higher school students used to study in various fields. They have to read different subjects which are not in their career streams. Therefore they attend college or universities to get ample knowledge of their field.
Universities and colleges have experienced staff in diverse fields. Everyone is professional in their stream therefore students gets the opportunity to learn from these persons(professors) various skills in their stream which is
not possible while studying in higher school. Secondly various projects, researches, assignments and practical scenarios are conducted in universities or colleges from where students get exposure and experience to various problems
which they might have to face in their real life while practicing. Like in dentistry the students have to work on tooth for scaling, wiring etc from which they get practical exposure."""
#1
def tien_xu_ly(str):
    newtxt = ""
    for c in str:
        if c.isalpha() or c.isspace():
            newtxt += c
    newtxt = newtxt.lower()
    return newtxt

tienxuly = tien_xu_ly(txt)
print(tienxuly)
#2
def dem_so_tu(str):
    return len(str.split(' '))
demsotu = dem_so_tu(tienxuly)
print(demsotu)
#3
def dem_cau(str):
    return len(str.split('.'))
demcau = dem_cau(txt)
print(demcau)
#4
def tach_tu(str):
    return str.split(' ')
tachtu = tach_tu(tienxuly)
print(tachtu)
# #5
def thong_ke(str):
    return Counter(str)
thongke = thong_ke(tachtu)
print(thongke)
print('\n')
#6
def sap_xep(ds):
    dsm = list(ds.items())
    n = len(dsm)

    for i in range(n):
        for j in range (0,n-i-1):
            if dsm[j][1] < dsm[j + 1][1]:
                dsm[j],dsm[j+1] = dsm[j+1], dsm[j]

    print(dsm)
    for item, index in dsm:
        print(f"tu xuat hien nhieu nhat la {item}: {index} lan")
        break
    
        
sap_xep(thongke)

