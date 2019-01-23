﻿using UnityEngine;
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
            list.Add(new CoordinateTuple(0, 1));
            list.Add(new CoordinateTuple(3, 1));
        }

		if (level == 117) {
            list.Add(new CoordinateTuple(0, 2));
            list.Add(new CoordinateTuple(3, 2));
        }

		if (level == 118) {
            list.Add(new CoordinateTuple(0, 3));
            list.Add(new CoordinateTuple(2, 3));
            list.Add(new CoordinateTuple(3, 3));
        }

		if (level == 119) {
            list.Add(new CoordinateTuple(0, 1));
            list.Add(new CoordinateTuple(4, 3));
        }

		if (level == 120) {
            list.Add(new CoordinateTuple(1, 0));
            list.Add(new CoordinateTuple(4, 1));
        }

		if (level == 121) {
            list.Add(new CoordinateTuple(0, 1));
            list.Add(new CoordinateTuple(1, 0));
            list.Add(new CoordinateTuple(1, 2));
            list.Add(new CoordinateTuple(2, 1));
        }

		if (level == 122) {
            list.Add(new CoordinateTuple(0, 1));
            list.Add(new CoordinateTuple(1, 1));
            list.Add(new CoordinateTuple(2, 0));
            list.Add(new CoordinateTuple(3, 1));
        }

		if (level == 123) {
            list.Add(new CoordinateTuple(1, 4));
            list.Add(new CoordinateTuple(4, 1));
        }


		//////LEVEL 200 - 299/----------------------------------------------------
		if (level == 200) {
            list.Add(new CoordinateTuple(1, 2));
        }

		if (level == 201) {
            list.Add(new CoordinateTuple(1, 1));
        }

		if (level == 202) {
            list.Add(new CoordinateTuple(0, 1));
        }

		if (level == 203) {
            list.Add(new CoordinateTuple(1, 2));
        }

		if (level == 204) {
            list.Add(new CoordinateTuple(4, 1));
            list.Add(new CoordinateTuple(4, 4));
            list.Add(new CoordinateTuple(1, 3));
        }

		if (level == 205) {
            list.Add(new CoordinateTuple(1, 3));
            list.Add(new CoordinateTuple(3, 1));
            list.Add(new CoordinateTuple(4, 4));
        }

		if (level == 206) {
            list.Add(new CoordinateTuple(1, 3));
            list.Add(new CoordinateTuple(3, 1));
        }

		if (level == 207) {
            list.Add(new CoordinateTuple(2, 0));
            list.Add(new CoordinateTuple(1, 1));
        }

		if (level == 208) {
            list.Add(new CoordinateTuple(0, 1));
            list.Add(new CoordinateTuple(0, 2));
            list.Add(new CoordinateTuple(1, 2));
        }

		if (level == 209) {
            list.Add(new CoordinateTuple(0, 2));
            list.Add(new CoordinateTuple(1, 1));
            list.Add(new CoordinateTuple(2, 0));
        }

		if (level == 210) {
            list.Add(new CoordinateTuple(0, 3));
            list.Add(new CoordinateTuple(3, 0));
            list.Add(new CoordinateTuple(0, 1));
        }

		if (level == 211) {
            list.Add(new CoordinateTuple(0, 2));
            list.Add(new CoordinateTuple(2, 2));
            list.Add(new CoordinateTuple(3, 2));
        }

		if (level == 212) {
            list.Add(new CoordinateTuple(1, 0));
            list.Add(new CoordinateTuple(1, 3));
            list.Add(new CoordinateTuple(3, 0));
        }

		if (level == 213) {
            list.Add(new CoordinateTuple(2, 0));
            list.Add(new CoordinateTuple(1, 3));
            list.Add(new CoordinateTuple(0, 3));
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
            list.Add(new CoordinateTuple(0, 1));
            list.Add(new CoordinateTuple(0, 4));
        }

        if (level == 401) //boat
        {
            list.Add(new CoordinateTuple(4, 1));
        }

        if (level == 402) //shoe
        {
            list.Add(new CoordinateTuple(1, 1));
        }

        if (level == 403) //heart
        {
            list.Add(new CoordinateTuple(1, 1));
            list.Add(new CoordinateTuple(4, 1));
        }

        if (level == 404) //lightbulb
        {
            list.Add(new CoordinateTuple(0, 1));
        }

        if (level == 405) //xmastree
        {
            list.Add(new CoordinateTuple(0, 1));
            list.Add(new CoordinateTuple(2, 1));
            list.Add(new CoordinateTuple(2, 2));
            list.Add(new CoordinateTuple(3, 2));
        }

        if (level == 406) //bottle
        {
            list.Add(new CoordinateTuple(0, 0));
            list.Add(new CoordinateTuple(2, 0));
            list.Add(new CoordinateTuple(3, 0));
            list.Add(new CoordinateTuple(2, 1));
            list.Add(new CoordinateTuple(0, 2));
            list.Add(new CoordinateTuple(1, 2));
            list.Add(new CoordinateTuple(2, 2));
            list.Add(new CoordinateTuple(3, 2));
        }

        if (level == 407) //mouse
        {
            list.Add(new CoordinateTuple(1, 1));
            list.Add(new CoordinateTuple(4, 1));
            list.Add(new CoordinateTuple(4, 4));
        }

        if (level == 408) //sun
        {
            list.Add(new CoordinateTuple(0, 0));
            list.Add(new CoordinateTuple(5, 5));
            list.Add(new CoordinateTuple(1, 4));
            list.Add(new CoordinateTuple(4, 1));
        }

        if (level == 409) //rocket
        {
            list.Add(new CoordinateTuple(5, 4));
            list.Add(new CoordinateTuple(4, 4));
            list.Add(new CoordinateTuple(4, 5));
            list.Add(new CoordinateTuple(3, 2));
            list.Add(new CoordinateTuple(2, 0));
            list.Add(new CoordinateTuple(2, 1));
        }

        if (level == 410) //sword
        {
            list.Add(new CoordinateTuple(4, 4));
            list.Add(new CoordinateTuple(2, 0));
            list.Add(new CoordinateTuple(2, 3));
            list.Add(new CoordinateTuple(0, 0));
        }

        if (level == 411) //star
        {
            list.Add(new CoordinateTuple(1, 1));
            list.Add(new CoordinateTuple(3, 1));
            list.Add(new CoordinateTuple(5, 3));
            list.Add(new CoordinateTuple(4, 2));
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
