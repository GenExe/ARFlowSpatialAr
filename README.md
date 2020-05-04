# ARFlowSpatialAr

Our project is about a prototype that uses Spatial AR to project an interactive usage tutorial on a coffee machine. It will show users how to correctly prepare a coffee out of the machine. The projection is done with a standard video projector and the coffee machine is tracked by a webcam. This allows the coffee machine to change its position while the projection remains correctly positioned on the machine. 

## Getting Started

Clone repo or download zip-file

### Prerequisites

Prerequisites without projection:

* Unity 2019.3.5f1
* Webcam
* Printed [QR_Code.jpg](https://github.com/GenExe/ARFlowSpatialAr/blob/master/QR_Code.jpg)

Prerequisites with projection:

* Unity 2019.3.5f1
* Webcam
* Printed [QR_Code.jpg](https://github.com/GenExe/ARFlowSpatialAr/blob/master/QR_Code.jpg)
* Projector
* 3d-mapping software which supports spout (e.g. HeavyM Trial or Pro)


End with an example of getting some data out of the system or using it for a little demo

## Usage

### Without Projector:

* Run MainScene in Unity
* Look with the camera at the QR Code until it is recognized.
* Select ImageTargetHolder/SproudCam (1) in the MainScene
* In the preview window you can now see what the output from the projector looks like.
* You can switch between the animations with the arrow up and arrow down keys

### With Projector:

Here it is assumed that HeavyM is used as 3d mapping software.


* Run MainScene in Unity
* Open HeavyM and follow the tutorial: https://www.youtube.com/watch?v=wAxWi7he26w
* Setup the output from HeavyM to the projector
* Look with the camera at the QR Code until it is recognized
* Now you should see an output from the projector
* Select ImageTargetHolder/SproudCam (1) in the MainScene in Unity and position it so that the point looks at the Nespresso model from the same axis as the projector looks at the QRCode. 
* Now in HeavyM adjust the output by dragging until the projection fits exactly.
* You can switch between the animations with the arrow up and arrow down keys

