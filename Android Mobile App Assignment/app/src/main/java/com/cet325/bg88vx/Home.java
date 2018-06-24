package com.cet325.bg88vx;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.content.Intent;
import android.widget.Button;


public class Home extends AppCompatActivity implements View.OnClickListener {

    // Create two button variables
    Button buttonPaintings;
    Button buttonRSS;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
       // Direct the activity to it's layout
        setContentView(R.layout.activity_home);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        // Set an onClickListner event for the two buttons
        buttonPaintings = (Button) findViewById(R.id.button_paintings);
        buttonPaintings.setOnClickListener(this);

        buttonRSS = (Button) findViewById(R.id.button_RSS);
        buttonRSS.setOnClickListener(this);


    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu.
        getMenuInflater().inflate(R.menu.menu_home, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Check which action bar button is selected
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }
        // If the store button is clicked create a new activity called Store
        if (id == R.id.to_store) {
            Intent intent = new Intent(this, Store.class);
            startActivity(intent);
            return true;}

        return super.onOptionsItemSelected(item);
    }

    // This looks for a click event
    @Override
    public void onClick(View view) {
        // Pulls the ID of the button that is clicked
        int id = view.getId();
        // If it is the button paitings create a new activity called ViewPaintings
        if (id == R.id.button_paintings) {
            Intent myIntent = new Intent(view.getContext(),
                    ViewPaintings.class);
            startActivity(myIntent);
        }

        // If it is the button RSS create a new activity called RSS
        if (id == R.id.button_RSS) {
            Intent myIntent = new Intent(view.getContext(),
                    RSS.class);
            startActivity(myIntent);
        }

    }


}
