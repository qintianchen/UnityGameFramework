# UnityGameFramework

## Feature
DevLog 120:
- Add lua deep copy function
- Use UpdateBeat to drive UIManager
- Add lua subscribe-publish event system

DevLog 116:
- UIManager Window Sorting order management
- UIManager Window Loaded Asynchronously: life cycle management, loading order-preserving

DevLog 115:
- LuaBehaviour and LuaBehaviourInspector for binding Unity Object to Lua

DevLog 114:
- ToLua EmmyLua annotation export - support extension methods
- ToLua EmmyLua annotation export - fix confusion of static method and member method
- Lua: Asynchronous method to synchronous method
- Lua: Check if null of userdata
- Lua: Wrap method in emmylua generic mode
- Content-UI: Add UIRoot
- Loading Method in Lua

DevLog 113:
- ToLua EmmyLua annotation export

DevLog 112:
- AVManager for AVPro
- VideoManager for Unity VideoPlayer
- AssetManager support single assetBundle build for one folder
- AssetManager support loading synchronously
- Load Lua with AssetManager 
- Build All Lua Files into one single AssetBundle
- Test Scene for ToLua

DevLog 110:
- Timer
- GameLogger for writing log into files
- A lazy, thread-safe SingleTon implementation
- Add Algorithm file

## TODO
- Kcp network system
  - protocol serialization
  - message compress and decompress
  - message encryption and decryption  
- AssetBundle Encryption
- AssetBundle CRC  
- MMO Network System
- Excel exporter
- Prototype-Based Programming in Lua
- LuaProfiler Integration

## The third party

|Name|Link|Description|
|---|---|---|
|DOTween|[http://dotween.demigiant.com](http://dotween.demigiant.com)|DOTween is a fast, efficient, fully type-safe object-oriented animation engine for Unity, optimized for C# users, free and open-source, with tons of advanced features|
|tolua|[https://github.com/topameng/tolua](https://github.com/topameng/tolua)|tolua# is a Unity lua static binder solution. the first solution that analyzes code by reflection and generates wrapper classes.|
|TrueSync|[https://doc.photonengine.com/en-US/truesync/current/getting-started/truesync-intro](https://doc.photonengine.com/en-US/truesync/current/getting-started/truesync-intro)|Photon TrueSync is a multiplayer lockstep system for Unity built on top of Photon Unity Networking.|
