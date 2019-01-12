using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoordinateTuple {

    public int RowNumber { get; private set; }
    public int ColumnNumber { get; private set; }

    public CoordinateTuple(int rowNumber, int columnNumber)
    {
        this.RowNumber = rowNumber;
        this.ColumnNumber = columnNumber;
    }
}
