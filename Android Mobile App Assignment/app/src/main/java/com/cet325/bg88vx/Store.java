package com.cet325.bg88vx;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.SharedPreferences;
import android.os.AsyncTask;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.text.InputType;
import android.text.TextUtils;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;

import android.support.v4.widget.CursorAdapter;
import android.widget.Adapter;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.AdapterView.OnItemSelectedListener;
import org.json.JSONException;

import java.util.ArrayList;
import java.util.List;


public class Store extends AppCompatActivity implements AdapterView.OnItemSelectedListener{

    //Create a bunch of varibales for use later
    private CursorAdapter cursorAdapter = null;
    private String selectedItem;
    public double Adult = 10.00;
    public double Adults = 0;
    public double Student = 0;
    public double Discount = 30;
    public double Discountt = 0;
    public double Euro = 1.13;
    public double GBP = 0.89;
    public String AdultS;
    public String DiscountS;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        // Direct the activity to it's layout
        setContentView(R.layout.activity_store);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        //Create a new JSONCurrecnyTask called JCT and execute it
        JSONCurrencyTask JCT = new JSONCurrencyTask();
        JCT.execute();
        // Look for saved prices for the Price and discount rate, if they exist assign them to the correct variables
        SharedPreferences price = getPreferences(0);
        String pv = price.getString("price", "10.00");
        Adult = Double.parseDouble(pv);
        SharedPreferences discount = getPreferences(0);
        String dv = discount.getString("discount", "30");
        Discount = Double.parseDouble(dv);
        //Assign variable Discount to Discountt
        Discountt = Discount;
        //Take the discount away from 100
        Discount = 100 - Discount;
        //Work out the student price
        Student = (Discount*Adult)/100;
        Discount = Discountt;
        //Assign the variables to their correct textviews
        String numberAsString = "£" + String.valueOf(Adult);
        TextView adult = (TextView)findViewById(R.id.textViewAdult);
        adult.setText(numberAsString);

        String numberasString = "£" + String.valueOf(Student);
        TextView student = (TextView)findViewById(R.id.textViewStudent);
        student.setText(numberasString);

        //Create the spinner
        Spinner spinner = (Spinner) findViewById(R.id.spinnerSelect);

        //Create the array fro the spinner options
        List<String> currency = new ArrayList<String>();
        //currency.add("Select Currency");
        currency.add("Great British Pounds");
        currency.add("Euros");

        //Creating adapter for spinner
        ArrayAdapter<String> dataAdapter = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_item, currency);

        //Drop down layout style
        dataAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);

        //Attaching data adapter to spinner
        spinner.setAdapter(dataAdapter);

        //Make sure that there is no spinner selection when the acticity is created
        int initialSelectedPosition = spinner.getSelectedItemPosition();
        spinner.setSelection(initialSelectedPosition, false);

        //If there is a preference for the selection get it and assign the selection
        SharedPreferences selection = getPreferences(0);
        int position = selection.getInt("selection", 0);
        spinner.setSelection(position);
        //Create an OnItemSelectedListner for the spinner
        spinner.setOnItemSelectedListener(this);

    }


    //Create a new class for the JSON
    private class JSONCurrencyTask extends AsyncTask<String, Void, double[]> {
        //Pull the data into 2 different strings from functions in the CurrencyHttpClient
        @Override
        protected double[] doInBackground(String... params) {
            String DataEU = ((new CurrencyHttpClient()).getConversionDataEU());

            String DataGBP = ((new CurrencyHttpClient()).getConversionDataGBP());
            //Assign the strings to an array and return it
            double[] mylist = new double[2];
            if (DataEU != null && DataGBP != null) {
                try {
                    mylist = JSONCurrencyParser.getCurrecny(DataEU, DataGBP);
                } catch (JSONException e) {
                    e.printStackTrace();
                }
                return mylist;
            } else return null;
        }


        @Override
        protected void onPostExecute(double[] mylist) {
            //Add the array variables to the variables
            if (mylist != null) {

                Log.d("dataEU", String.valueOf(mylist[0]));
                Log.d("dataGBP", String.valueOf(mylist[1]));
                GBP = mylist[0];
                Euro = mylist[1];
            } else {
                Toast.makeText(getApplicationContext(), "Unable to retrieve data", Toast.LENGTH_LONG).show();
            }
        }
    }



    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_store, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {

        int id = item.getItemId();

        //Create a dialog box
        if (id == R.id.action_settings) {
            AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(Store.this);
            alertDialogBuilder
                    .setTitle("Options")
                    .setMessage("What would you like to do?")
                    .setPositiveButton("Edit Ticket Options", new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialog, int which) {
                            LayoutInflater li = LayoutInflater.from(Store.this);
                            View getEmpIdView = li.inflate(R.layout.set_price, null);

                            //create alert dialog and link to view created
                            AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(Store.this);
                            alertDialogBuilder.setView(getEmpIdView);
                            //Create 2 edittexts and set them to only allow number input
                            final EditText AdultP = (EditText)getEmpIdView.findViewById(R.id.editText_adult);
                            AdultP.setInputType(InputType.TYPE_CLASS_NUMBER);
                            final EditText DiscountR = (EditText)getEmpIdView.findViewById(R.id.editText_discount);
                            DiscountR.setInputType(InputType.TYPE_CLASS_NUMBER);

                            alertDialogBuilder
                                    .setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
                                        @Override
                                        public void onClick(DialogInterface dialog, int which) {
                                            Toast.makeText(getApplicationContext(),
                                                    "Action Cancelled", Toast.LENGTH_LONG).show();
                                        }
                                    })
                                    .setPositiveButton("Add", new DialogInterface.OnClickListener() {
                                        @Override
                                        public void onClick(DialogInterface dialog, int which) {
                                            try{
                                                //Assign the editxts to variables
                                                AdultS =  AdultP.getText().toString();
                                                DiscountS = DiscountR.getText().toString();
                                                //Create a bunch of IF statments which change the variables depending on what, if anything is added tot he edittexts
                                                if (TextUtils.isEmpty(AdultS) && TextUtils.isEmpty(DiscountS)) {
                                                    return; // or break, continue, throw
                                                }
                                                if (AdultS != null && TextUtils.isEmpty(DiscountS)){

                                                    Adult = Double.parseDouble(AdultS);

                                                    Discount = 100 - Discount;
                                                    Student = (Discount*Adult)/100;
                                                    String numberAsString = "£" + String.valueOf(Adult);
                                                    TextView adult = (TextView)findViewById(R.id.textViewAdult);
                                                    adult.setText(numberAsString);
                                                    String numberasString = "£" + String.valueOf(Student);
                                                    TextView student = (TextView)findViewById(R.id.textViewStudent);
                                                    student.setText(numberasString);

                                                    SharedPreferences selection = getPreferences(0);
                                                    SharedPreferences.Editor editor = selection.edit();
                                                    editor.putString("price", AdultS);
                                                    editor.commit();

                                                }

                                                if (TextUtils.isEmpty(AdultS) && DiscountS != null){

                                                    Discount = Double.parseDouble(DiscountS);
                                                    Discount = 100 - Discount;
                                                    Student = (Discount*Adult)/100;
                                                    String numberAsString = "£" + String.valueOf(Adult);
                                                    TextView adult = (TextView)findViewById(R.id.textViewAdult);
                                                    adult.setText(numberAsString);
                                                    String numberasString = "£" + String.valueOf(Student);
                                                    TextView student = (TextView)findViewById(R.id.textViewStudent);
                                                    student.setText(numberasString);
                                                    SharedPreferences selections = getPreferences(0);
                                                    SharedPreferences.Editor editors = selections.edit();
                                                    editors.putString("discount", DiscountS);
                                                    editors.commit();

                                                }

                                                if (AdultS !=null && DiscountS !=null){
                                                    Adult = Double.parseDouble(AdultS);
                                                    Discount = Double.parseDouble(DiscountS);
                                                    Discount = 100 - Discount;
                                                    Student = (Discount*Adult)/100;
                                                    String numberAsString = "£" + String.valueOf(Adult);
                                                    TextView adult = (TextView)findViewById(R.id.textViewAdult);
                                                    adult.setText(numberAsString);
                                                    String numberasString = "£" + String.valueOf(Student);
                                                    TextView student = (TextView)findViewById(R.id.textViewStudent);
                                                    student.setText(numberasString);
                                                    SharedPreferences selection = getPreferences(0);
                                                    SharedPreferences.Editor editor = selection.edit();
                                                    editor.putString("price", AdultS);
                                                    editor.commit();
                                                    SharedPreferences selections = getPreferences(0);
                                                    SharedPreferences.Editor editors = selections.edit();
                                                    editors.putString("discount", DiscountS);
                                                    editors.commit();

                                                }

                                                Toast.makeText(getApplicationContext(),
                                                        "Ticket Options Changed", Toast.LENGTH_LONG).show();

                                            }catch (NumberFormatException e){
                                                e.printStackTrace();
                                            }catch (Exception e){
                                                e.printStackTrace();
                                            }
                                        }
                                    }).create()
                                    .show();

                        }
                    })

                    .setNeutralButton("Cancel", new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialog, int which) {
                            Toast.makeText(getApplicationContext(),
                                    "Action Cancelled", Toast.LENGTH_LONG).show();
                            return;
                        }
                    }).create()
                    .show();
            return true;
        }

        if (id == R.id.menu_refresh) {
            //Allo for on button press to create a new JSONTASK and pull through the API data
            JSONCurrencyTask JCT = new JSONCurrencyTask();
            JCT.execute();
            Toast.makeText(getApplicationContext(),"Exchange Rates Updated", Toast.LENGTH_LONG).show();
        }


        return super.onOptionsItemSelected(item);
    }


    public void showpriceGBP(){
        //A function that runs when GBP is selected on the spinner

        Adults = Adult;
        Adult= Adult * GBP;
        Adult = Math.round(Adult * 100);
        Adult = Adult/100;
        Discountt = Discount;
        Discount = 100 - Discount;
        Student = (Discount*Adult)/100;
        Discount = Discountt;
        Student = Math.round(Student * 100);
        Student = Student/100;
        String numberAsString = "£" + String.valueOf(Adult);
        TextView adult = (TextView)findViewById(R.id.textViewAdult);
        adult.setText(numberAsString);
        String numberasString = "£" + String.valueOf(Student);
        TextView student = (TextView)findViewById(R.id.textViewStudent);
        student.setText(numberasString);

    }


    public void showpriceEuro(){

        //A function that runs when Euro is selected on the spinner

        Adults = Adult;
        Adult=Adults;
        Adult= Adult * Euro;
        Adult = Math.round(Adult * 100);
        Adult = Adult/100;
        Discountt = Discount;
        Discount = 100 - Discount;
        Student = (Discount*Adult)/100;
        Discount = Discountt;
        Student = Math.round(Student * 100);
        Student = Student/100;
        String numberAsString = "€" + String.valueOf(Adult);
        TextView adult = (TextView)findViewById(R.id.textViewAdult);
        adult.setText(numberAsString);
        String numberasString = "€" + String.valueOf(Student);
        TextView student = (TextView)findViewById(R.id.textViewStudent);
        student.setText(numberasString);

    }

    @Override
    public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
        // On selecting a spinner item
        if (position == 0){

            showpriceGBP();
            String item = parent.getItemAtPosition(position).toString();
            // Showing selected spinner item
            Toast.makeText(parent.getContext(), "Selected: " + item, Toast.LENGTH_LONG).show();
            //Create a preference for which spinner optionis selected
            SharedPreferences selection = getPreferences(0);
            SharedPreferences.Editor editor = selection.edit();
            editor.putInt("selection", position);
            editor.commit();
        }

        else if (position == 1){

            showpriceEuro();
            String item = parent.getItemAtPosition(position).toString();
            // Showing selected spinner item
            Toast.makeText(parent.getContext(), "Selected: " + item, Toast.LENGTH_LONG).show();
            //Create a preference for which spinner optionis selected
            SharedPreferences selection = getPreferences(0);
            SharedPreferences.Editor editor = selection.edit();
            editor.putInt("selection", position);
            editor.commit();
        }

    }
    public void onNothingSelected(AdapterView<?> arg0) {

    }




}
