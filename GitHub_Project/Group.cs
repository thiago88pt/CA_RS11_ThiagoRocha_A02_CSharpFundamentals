﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace P00_GitHubProjectGroups
{
    internal class GroupElements
    {
        #region Variables

        internal int GroupNumber { get; set; }
        internal string[] TraineeName { get; set; }
        internal int[] TraineeNumber { get; set; }

        #endregion

        #region Structure

        internal GroupElements(int groupNumber, string[] traineeName, int[] traineeNumber)
        {
            GroupNumber = groupNumber;
            TraineeName = traineeName;
            TraineeNumber = traineeNumber;
        }

        #endregion

        #region Print

        internal void PrintGroups()
        {
            Utility.WriteMessage($"Grupo {GroupNumber}:");
            for (int i = 0; i < TraineeName.Length; i++)
            {
                Utility.WriteMessage($"- {TraineeName[i]}: {TraineeNumber[i]}", "\n", "\n");
            }
        }

        #endregion
    }
}
