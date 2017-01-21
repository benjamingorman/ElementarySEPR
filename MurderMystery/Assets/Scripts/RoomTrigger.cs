using UnityEngine;
using System.Collections;

public class RoomDetector : MonoBehaviour
{
    public Constants.Rooms roomLocation = Constants.Rooms.GrandHall; // default to GrandHall

    void OnTriggerEnter2D(Collider2D coll)
    {
        GameObject collObj = coll.gameObject;
        switch (collObj.name)
        {
            case "Kitchen": EnterRoom(Constants.Rooms.Kitchen); break;
            case "Lift": EnterRoom(Constants.Rooms.Lift); break;
            case "Staircase 1": EnterRoom(Constants.Rooms.Staircase1); break;
            case "Staircase 2": EnterRoom(Constants.Rooms.Staircase2); break;
            case "Bin Bay": EnterRoom(Constants.Rooms.BinBay); break;
            case "Business Room 1": EnterRoom(Constants.Rooms.BusinessRoom1); break;
            case "Business Room 2": EnterRoom(Constants.Rooms.BusinessRoom2); break;
            case "Exhibition Room": EnterRoom(Constants.Rooms.ExhibitionRoom); break;
            case "Interaction Island": EnterRoom(Constants.Rooms.InteractionIsland); break;
            case "Lecture Theatre": EnterRoom(Constants.Rooms.LectureTheatre); break;
            case "Reception": EnterRoom(Constants.Rooms.Reception); break;
            case "Terrace": EnterRoom(Constants.Rooms.Terrace); break;
            default:
                Debug.Log("OnTriggerEnter2D called but object is not a room");
                break;
        }
    }

    private void EnterRoom(Constants.Rooms room)
    {
        if (roomLocation != room)
        {
            Debug.Log("Changed to room: " + room.ToString());
            roomLocation = room;
            MessagePasser.OnPlayerChangeRoom(room);
        }
    }
}