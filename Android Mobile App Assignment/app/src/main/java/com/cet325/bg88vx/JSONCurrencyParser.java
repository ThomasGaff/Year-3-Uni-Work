package com.cet325.bg88vx;

import android.util.Log;



import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.Arrays;
import java.util.Calendar;
import java.util.Date;
import java.util.List;

public class JSONCurrencyParser {

    public static double[] getCurrecny(String dataEU, String dataGBP) throws JSONException {

        //Create JSONObject from the data
        JSONObject jObjEU = new JSONObject(dataEU);
        JSONObject jObjGBP = new JSONObject(dataGBP);
        JSONObject EURates = jObjEU.getJSONObject("rates");
        JSONObject GBPRates = jObjGBP.getJSONObject("rates");
        //Create an array and asign the JSONObjects to it
        double[] mylist = new double[2];
        mylist[0] = EURates.getDouble("GBP");
        mylist[1] = GBPRates.getDouble("EUR");
        //Return the array
        return mylist;
    }
}

