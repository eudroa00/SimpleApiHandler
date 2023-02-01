using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Threading.Tasks;
using Newtonsoft.Json;


public class ApiRequester : MonoBehaviour
{

    [ContextMenu("Get")]
    public async void RequestSubmiter(string uri)
    {
        using UnityWebRequest www = UnityWebRequest.Get(uri);
        var webRequest = www.SendWebRequest();

        while (!webRequest.isDone)
            await Task.Yield();

        var jsonResponse = www.downloadHandler.text; //Retrieve JSON response as a string.

        if (www.result != UnityWebRequest.Result.Success)
            Debug.LogError($"Failed: {www.error}");
        else 

            try
            {
                var result = JsonConvert.DeserializeObject<List<contractData>>(jsonResponse); // JSON to c#
                Debug.Log("Success.");
                Debug.Log(jsonResponse);
            }
            catch(Exception ex)
            {
                    Debug.LogError($"Could not parse response: {jsonResponse}. {ex.Message}");
            }
    }   
}

public class BodyData
{
    public string airlineName;
}