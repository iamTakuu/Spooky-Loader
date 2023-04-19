<h1 align="center">Spooky Loader</h1>
<p align="center">
  <img src="https://i.imgur.com/nV1wHGk.jpg" alt="ghst" width="90" />
</p>
<p align="center">
  A plug-and-play, easy to use Scene Loader for your Big Worlds!
</p>

# Getting Started

## Context
Before using this tool, keep in mind that it is for a specific use in which you have a big level that might work better in a multi-scene workflow instead of loading the entire level at runtime. This allows scenes to be loaded in and out as needed, improving overall performance and scalability.

<p>This tool is greatly inspired by <a href="http://www.unity-glue.com/html/#h.cwcpg3nzg7bx">The Unity Glue</a> and this 
<a href="https://youtu.be/KRmqy22z0SM">2017 GDD Talk on Multi-Scene Editing</a>. Along side these two I took the implementation that Unity shows on their Youtube channel and attempted to improve on it where possible, while also adding some nice quality of life features for designers. I would highly recomend watching <a href="https://youtu.be/zObWVOv1GlE">their video</a> to gain a basic understanding of how Spooky Loader works.

</p>

## Installation

### Git URL (Recommended)

1. Open the package manager window
2. Click the plus icon
3. Choose ``"Add package from git URL..."``
4. Use the link below.

```
https://github.com/iamTakuu/Spooky-Loader.git
```

# How to Use
  ## Setup
  <img align="left" src="https://user-images.githubusercontent.com/88771608/228963364-6a2f207f-3c0c-439f-8fc5-a9cda12cc623.png">
 
  The idea setup has a "Base" scene that holds persistent entities throughout the scene.
  
  You'll need Gameobjects named after the scenes you want to load in and out. These will hold the **SpookySceneLoader** Component
  
  **NOTE**: It's **key** that the gameobject is named after the scene AND the scenes are added to the Build Order.
  
  Set up your level as need be, breaking it up into smaller, more appropriate scenes.
  
  
  ## SpookySceneLoader.cs
  <img align="left" src="https://user-images.githubusercontent.com/88771608/233089631-c6af6208-f474-4175-8a53-175203b779eb.png" width="300">
  
  The **SpookySceneLoader** component is attached to the empty Gameobject created earlier, all it needs from you is the scene's current status and a       **Trigger Prefab** (which is of type **SpookyTrigger**). Tick _isLoaded_ when the scene you start with is already present, otherwise leave it as false.
  The _Add Trigger_ button creates a new instance of the trigger prefab as a child of the Gameobject with the Loader. A scene can have multiple triggers, in the event that there are multiple entrances to the level.

  ## SpookyTrigger.cs and Trigger Prefab
  
  You can make your own custom _Trigger Prefab_ if need be, you just need to create a prefab that has a box collider (set to isTrigger) and give it the component _SpookyTrigger_. Add this prefab to the loader, and the _Add Trigger_ button will take care of assigning the **OnSceneTrigger()** Unity Event.
This event can also be used to add any extended functionality you might need.
