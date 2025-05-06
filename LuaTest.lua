print("111111")
local var1=50

local table1={}
for i = 1, var1, 1 do
    table.insert(table1,i)
   if i==10 then
      break
   end

    if i==25 then
        break
    end
  
end

local Tabe2={}
local Tabe3={}

for i = 1, #table1, 1 do
    print("pos:"..i.."value:"..table1[i])
    
end