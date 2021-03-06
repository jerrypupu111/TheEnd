﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BaisemaManager : MonoBehaviour {

	List<Baisema> baisemaList;
    public static BaisemaManager instance;
    public Baisema baisemaPrefab;

    void Awake()
	{
		baisemaList = new List<Baisema>();
		instance = this;
	}
	public void addBaisema(Baisema b)
	{
		baisemaList.Add(b);
	}
	public void explodeAll()
	{
		foreach(Baisema b in baisemaList)
		{
			b.explode();
		}
		baisemaList.Clear();
		
	}
    public void SetUpAll()
    {
        foreach (Baisema b in baisemaList)
        {
            b.SetUp();
        }
    }
    public Baisema genBaisema(Vector3 pos)
    {
        Baisema newBaisema = Instantiate(baisemaPrefab, pos, Quaternion.identity) as Baisema;
        addBaisema(newBaisema);
        return newBaisema;
    }


}
