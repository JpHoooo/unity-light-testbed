# :fire: Test the lightting effect in the HDRP :fire:

<b>This is the reposity where the visual effects produced by Unity3D are stored.</b>

Visit my blog for more details:[Jphoooo](https://jphoooo.github.io/posts/unity-light.html)

Unity version : `2020.2.6 f1` or `later`

### 🌫️ 20210914

#### :star: Preview of tyndall effect 

![preview](https://github.com/JpHoooo/unity-light-testbed/blob/main/Assets/Sketch20210914/imgs/preview.gif)

#### :star: Trigger the Tyndall effect of lights

1. Add a volume with fog, set enable of `Volumetric Fog` true 

![preview](https://github.com/JpHoooo/unity-light-testbed/blob/main/Assets/Sketch20210914/imgs/volume.jpg)

2. Enable Volumetrics under lighting components

![preview](https://github.com/JpHoooo/unity-light-testbed/blob/main/Assets/Sketch20210914/imgs/light.jpg)

### 🔦 20210729

#### :star: Scene Images
 
![1](https://github.com/JpHoooo/unity-light-testbed/blob/main/Assets/Sketch20210729/Imgs/0.png)
 
#### :star: Scene Setting 
 
![0](https://github.com/JpHoooo/unity-light-testbed/blob/main/Assets/Sketch20210729/Imgs/0.png)  

1. Open the <b>``"LightCookies"``</b> folder, select the one of the pictures.  
 
![2](https://github.com/JpHoooo/unity-light-testbed/blob/main/Assets/Sketch20210729/Imgs/2.png)  
 
2. Change the <b>``Warp Mode``</b> in the inspector to Clamp.  
  
![3](https://github.com/JpHoooo/unity-light-testbed/blob/main/Assets/Sketch20210729/Imgs/3.png)  

3. Put the picture into the Emisson <b>``Cookie``</b> of the light component

#### :star: Development Enviroment
Unity Version: `2020.2.6f1`
HDRP Version:`10.3.2`

#### :star: Supplement 
You can use  the Emisson <b>``IES``</b> of the light component to make more realistic lighting  
The premise is to have .IES file  
This link jumps to the [IES Library](https://ieslibrary.com/en/browse)
