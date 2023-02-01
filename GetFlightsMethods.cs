using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetFlightsMethods : MonoBehaviour
{
    ApiRequester apiRequester;

    public void GetAirline( string airlineNameInput ) // this string is selected in the UI
    {
        string uri = "http://localhost:5000/api/flights/showList?airlineName=" + airlineNameInput;
        apiRequester.RequestSubmiter(uri);
    }
    public void GetFlight()
    {

    }

    public void GetDestination()
    {

    }

    public void GetOrigin()
    {

    }

    public void GetBoardingGate()
    {

    }

    public void GetState()
    {

    }
}
    

    

