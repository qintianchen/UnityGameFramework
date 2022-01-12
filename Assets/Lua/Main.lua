inspect = require("inspect")

local count = 0
for k, v in pairs(_G) do
    count = count + 1
end
GameLogger.Info(("_G 共有 %s 个项目"):format(count))
