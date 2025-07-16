print("以下为热补丁")
xlua.hotfix(CS.HotFix_1_try,"Add",function (self,a,b)
	print("热更里面的add")
	print("热更里面的add")
	
	return a+b
end)

xlua.hotfix(CS.HotFix_1_try,"Speak",function()

	print("热更里面的speak")

end)