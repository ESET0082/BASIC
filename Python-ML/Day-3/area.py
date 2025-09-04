'''find area of the rectangle'''

length=10
width=12
print("area :",length*width)

''' check the type of list'''

l=['i0',1]
print(l)
print(type(l))

'''
list opration :-
    add :- append(),insert(index,data)
    remove :- remove(),pop()
    access : fruits[0]
    range : fruits[1:3]-> get range
     sort : sort()

'''
l3=[1,2,3,4,50,6,7,8,9,10]
l3.sort()
print(l3)

''' Dictionaries 
    add/update :- dict['int']=12,
    remove :- .pop(key_name)
'''
dict = {
    'empid':1,
    'name':'gopal',
    'age':20,
    'marks':100
}
print(dict)
print(type(dict))

''' tuple ---> inmutable(unchange)
    add/update :- cannot
    remove :- cannot
'''


''' conditional statement
    if
    if else
    if elif else
'''

'''if else'''
age=20
if age>18:
    print("he/she can drink")
else:
    print("he/she cannot drink")
    
'''if elif else'''

mark=95
if mark>=90:
    print("grade A")
elif mark>=75:
    print("grade B")
else:
    print("grade C")
    
    
""" loop
    - for loop
    - while loop
"""

"""for loop"""
for i in range(1,5):
    print(i)
    
for i in [1,4,0]:
    print(i)
    
"""while loop"""
cnt=0
while(cnt<3):
    print(cnt)
    cnt+=1
    
"""break and continue"""
print("break and continue")
for i in range(1,11):
    if(i%2==0):
        continue
    else:
        print(i)
        if(i==7):
            break
