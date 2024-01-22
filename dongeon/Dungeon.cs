using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DungeonPlace
{
    public Room[] m_RoomArray;
    private int m_iRoomIndex;
    public DungeonPlace()
    {
        m_RoomArray = new Room[5];
        m_iRoomIndex = 0;
    }

   



    /// <summary>
    /// @param p_Hero 
    /// @return
    /// </summary>
    public void Explore(Hero p_Hero)
    {
        // TODO implement here

        while(p_Hero.m_iLifePoints != 0)
        {
            m_RoomArray[m_iRoomIndex].OpenDoor(p_Hero);
        }

    }

}
