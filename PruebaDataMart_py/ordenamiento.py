def merge_arrays (array_int1, array_int2):
    final_array_int = array_int1 + array_int2    
    final_array_int.sort()
    return final_array_int


#TEST   
array_int1 =[-2, 0,1,2,3,4,6,9,10,13,20,35]
array_int2=[-10, 1,7,10,15,22]
print (merge_arrays(array_int1,array_int2))
#print("[-10, -2, 0, 1, 1, 2, 3, 4, 6, 7, 9, 10 ,10 ,13 ,15 ,20 ,22, 35]") 

