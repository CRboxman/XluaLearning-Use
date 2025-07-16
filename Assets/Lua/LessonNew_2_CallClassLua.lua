print("以下是新的测试lua------------------------------------")
local obj1=CS.Lesson1()
--[[
print(obj1.arr.Length)
print(obj1.arr[2])
for i=0,obj1.arr.Length-1 do
	print(i)
end
]]
local arr1=CS.System.Array.CreateInstance(typeof(CS.System.Int32),10)
print(arr1.Length)


