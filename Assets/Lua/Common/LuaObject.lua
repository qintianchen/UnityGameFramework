function NewObjectFrom(base)
    if not base then
        LogError("base can not be nil")
        base = {}
    end
    return setmetatable({ __base = base }, {
        __index = function(t, k) return rawget(t, k) or base[k] end
    })
end

LuaObject = NewObjectFrom({})
