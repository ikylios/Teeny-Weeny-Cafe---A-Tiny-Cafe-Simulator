using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBeverage
{
    String getName();
    List<Ingredient> getProperties();
}
