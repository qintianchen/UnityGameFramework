function NewObjectFrom(base)
    return setmetatable({ __base = base }, {
        __index = function(t, k) return rawget(t, k) or base[k] end
    })
end

LuaObject = NewObjectFrom({})
