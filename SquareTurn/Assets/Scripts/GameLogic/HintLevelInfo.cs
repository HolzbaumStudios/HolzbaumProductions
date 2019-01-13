using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class HintLevelInfo {

    List<CoordinateTuple> list;

    private static List<int> levelsWithHintsEnabled = new List<int>();

    public static bool IsHintEnabled(int levelNumber)
    {
        return levelsWithHintsEnabled.Contains(levelNumber);
    }

    public static void AddLevelToHintList(int levelNumber)
    {
        levelsWithHintsEnabled.Add(levelNumber);
    }

	//----------------LEVELS------------------
	public List<CoordinateTuple> GetHintFields(int level){

        list = new List<CoordinateTuple>();
        //////LEVEL 100 - 199/----------------------------------------------------

        if (level == 100) {
            list.Add(new CoordinateTuple(1, 1));
		}

		if (level == 101) {
            list.Add(new CoordinateTuple(0, 2));
        }

		if (level == 102) {
            list.Add(new CoordinateTuple(0, 1));
        }

		if (level == 103) {
            list.Add(new CoordinateTuple(0, 0));
            list.Add(new CoordinateTuple(3, 3));
        }

		if (level == 104) {
            list.Add(new CoordinateTuple(0, 0));
            list.Add(new CoordinateTuple(3, 3));
        }

		if (level == 105) {
            list.Add(new CoordinateTuple(0, 2));
        }

		if (level == 106) {
            list.Add(new CoordinateTuple(2, 0));
        }

		if (level == 107) {
            list.Add(new CoordinateTuple(0, 2));
        }

		if (level == 108) {
            list.Add(new CoordinateTuple(3, 0));
            list.Add(new CoordinateTuple(1, 3));
        }

		if (level == 109) {
            list.Add(new CoordinateTuple(0, 4));
            list.Add(new CoordinateTuple(3, 1));
        }

		if (level == 110) {
            list.Add(new CoordinateTuple(1, 1));
        }

		if (level == 111) {
            list.Add(new CoordinateTuple(1, 1));
            list.Add(new CoordinateTuple(4, 4));
        }

		if (level == 112) {
            list.Add(new CoordinateTuple(4, 1));
            list.Add(new CoordinateTuple(1, 4));
        }

		if (level == 113) {
            list.Add(new CoordinateTuple(2, 1));
        }

		if (level == 114) {
            list.Add(new CoordinateTuple(1, 2));
        }

		if (level == 115) {
            list.Add(new CoordinateTuple(0, 1));
            list.Add(new CoordinateTuple(3, 1));
        }

		if (level == 116) {

		}

		if (level == 117) {

		}

		if (level == 118) {

		}

		if (level == 119) {

		}

		if (level == 120) {

		}

		if (level == 121) {

		}

		if (level == 122) {

		}

		if (level == 123) {

		}


		//////LEVEL 200 - 299/----------------------------------------------------
		if (level == 200) {

		}

		if (level == 201) {

		}

		if (level == 202) {

		}

		if (level == 203) {

		}

		if (level == 204) {

		}

		if (level == 205) {

		}

		if (level == 206) {

		}

		if (level == 207) {

		}

		if (level == 208) {

		}

		if (level == 209) {

		}

		if (level == 210) {

		}

		if (level == 211) {

		}

		if (level == 212) {

		}

		if (level == 213) {

		}

		if (level == 214) {

		}

		if (level == 215) {

		}

		if (level == 216) {

		}

		if (level == 217) {

		}

		if (level == 218) {

		}

		if (level == 219) {

		}

		if (level == 220) {

		}

		if (level == 221) {

		}

		if (level == 222) {

		}

		if (level == 223) {

		}


		//////LEVEL 300 - 399/----------------------------------------------------
		if (level == 300) {

		}

		if (level == 301) {

		}

		if (level == 302) {

		}

		if (level == 303) {

		}

		if (level == 304) {

		}

		if (level == 305) {

		}

		if (level == 306) {

		}

		if (level == 307) {

		}

		if (level == 308) {

		}

		if (level == 309) {

		}

		if (level == 310) {

		}

		if (level == 311) {

		}

		if (level == 312) {

		}

		if (level == 313) {

		}

		if (level == 314) {

		}

		if (level == 315) {

		}

		if (level == 316) {

		}

		if (level == 317) {

		}

		if (level == 318) {

		}

		if (level == 319) {

		}

		if (level == 320) {

		}

		if (level == 321) {

		}

		if (level == 322) {

		}

		if (level == 323) {

		}

        //////LEVEL 400 - 499/----------------------------------------------------
        if (level == 400) //tree
        {

        }

        if (level == 401) //boat
        {

        }

        if (level == 402) //shoe
        {

        }

        if (level == 403) //heart
        {

        }

        if (level == 404) //lightbulb
        {

        }

        if (level == 405) //xmastree
        {

        }

        if (level == 406) //bottle
        {

        }

        if (level == 407) //mouse
        {

        }

        if (level == 408) //sun
        {

        }

        if (level == 409) //rocket
        {

        }

        if (level == 410) //sword
        {

        }

        if (level == 411) //star
        {

        }

        if (level == 412) //house
        {

        }

        if (level == 413) //roflcopter
        {

        }

        if (level == 414) //plane
        {

        }

        if (level == 415) //desktop lamp
        {

        }

        if (level == 416) //tie
        {

        }

        if (level == 417) //rocket
        {

        }

        if (level == 418) //lamp upside down
        {

        }

        if (level == 419) //art
        {

        }

        if (level == 420) //candle holder
        {

        }

        if (level == 421) //ankh
        {

        }

        if (level == 422) //bomb
        {

        }

        if (level == 423) //screwdriver
        {

        }
        //////////////////////////////////////////////////
        return list;
	}
	
}
