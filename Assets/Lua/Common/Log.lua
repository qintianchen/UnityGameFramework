local Info = GameLogger.Info
local Warning = GameLogger.Warning
local Error = GameLogger.Error

function Log(msg)
    Info(msg .."\n".. debug.traceback())
end

function LogWarning(msg)
   Warning(msg .."\n" ..debug.traceback())
end

function LogError(msg)
    Error(msg .."\n" ..debug.traceback())
end

function LogWithColor(msg, color)
    msg = ("<color=%s>%s</color>"):format(color, msg)
    Log(msg)
end

function LogYellow(msg)
    LogWithColor(msg, "#ffff00")
end

function LogGray(msg)
    LogWithColor(msg, "#BEBEBE")
end

function LogBlue(msg)
    LogWithColor(msg, "#0000FF")
end

function LogGreen(msg)
    LogWithColor(msg, "#00FF00")
end

function LogForestGreen(msg)
    LogWithColor(msg, "#228B22")
end

function LogMagenta(msg)
    LogWithColor(msg, "#FF00FF")
end