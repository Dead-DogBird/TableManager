using System;
using System.Collections;
using System.Collections.Generic;
using TableManager;
using UnityEngine;

public class LocalDbTest : MonoBehaviour
{
    private void Start()
    {
        var itemDataRow = LocalDb.Get<excelsRow>("0");
        Debug.Log($"{itemDataRow.id} {itemDataRow.name}");

        foreach (var testDataRow in LocalDb.GetEnumerable<TestDataRow>())
        {
            Debug.Log($"{testDataRow.id} {testDataRow.name} {testDataRow.age}");
        }
    }
}
