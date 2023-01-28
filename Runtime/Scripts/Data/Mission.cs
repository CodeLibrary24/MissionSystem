using System.Collections.Generic;
using UnityEngine;

namespace CodeLibrary24.MissionSystem
{
    public class Mission : ScriptableObject
    {
        public string missionName;
        public string description;
        public List<Mission> subMissions;
    }
}
