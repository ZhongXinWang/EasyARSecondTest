/**
* Copyright (c) 2015-2016 VisionStar Information Technology (Shanghai) Co., Ltd. All Rights Reserved.
* EasyAR is the registered trademark or trademark of VisionStar Information Technology (Shanghai) Co., Ltd in China
* and other countries for the augmented reality technology developed by VisionStar Information Technology (Shanghai) Co., Ltd.
*/

using UnityEngine;
namespace EasyAR
{
	public class MyImageTargetBehaviours : ImageTargetBaseBehaviour
	{
		
		protected override void Awake ()
		{
			base.Awake ();
			TargetFound += OnTargetFound;
			TargetLost += OnTargetLost;
			TargetLoad += OnTargetLoad;
			TargetUnload += OnTargetUnload;
			
		}
		
		protected override void Start ()
		{
			base.Start ();
			HideObjects (transform);
		}
		
		void ShowObjects(Transform trans){
			
			for (int i = 0; i < trans.childCount; i++) {
				
				ShowObjects(trans.GetChild(i));
				
			}
			
			if (transform != trans) {
				
				gameObject.SetActive(true);
				
			}
			
		}
		void HideObjects(Transform trans){
			
			
			for (int i = 0; i < trans.childCount; i++) {
				
				
				HideObjects(trans.GetChild(i));
				
			}
			if (trans != transform) {
				
				gameObject.SetActive(false);
				
			}
			
		}
		void OnTargetFound(ImageTargetBaseBehaviour behaviour){
			
			
			Debug.Log ("found"+Target.Id);
			ShowObjects (transform);
			
		}
		
		void OnTargetLost(ImageTargetBaseBehaviour behaviour){
			
			Debug.Log ("lost"+Target.Id);
			HideObjects (transform);
			
		}
		
		void OnTargetLoad(ImageTargetBaseBehaviour behaviour,ImageTrackerBaseBehaviour tracker,bool status){
			
			
			Debug.Log ("Load"+Target.Id+"--"+status);
			
		}
		
		
		void OnTargetUnload(ImageTargetBaseBehaviour behaviour,ImageTrackerBaseBehaviour tracker,bool status){
			
			
			Debug.Log ("unload"+Target.Id+"--"+status);
			
		}
	}
}
