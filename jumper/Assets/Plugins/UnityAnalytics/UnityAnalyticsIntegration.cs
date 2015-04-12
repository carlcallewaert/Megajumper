using UnityEngine;
using System.Collections;
using UnityEngine.Cloud.Analytics;

public class UnityAnalyticsIntegration : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
		const string projectId = "6a4cc27b-8b83-4225-9dde-42bd71c3a0d2";
		UnityAnalytics.StartSDK (projectId);
		
	}
	
}