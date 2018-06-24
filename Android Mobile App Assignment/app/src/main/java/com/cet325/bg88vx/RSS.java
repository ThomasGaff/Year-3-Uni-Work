package com.cet325.bg88vx;

import android.app.AlertDialog;
import android.app.ProgressDialog;
import android.content.DialogInterface;
import android.os.AsyncTask;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.support.v7.widget.Toolbar;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import com.google.gson.Gson;

import com.cet325.bg88vx.Adapter.FeedAdapter;
import com.cet325.bg88vx.Common.HTTPDataHandler;
import com.cet325.bg88vx.Model.RSSObject;

public class RSS extends AppCompatActivity {

    Toolbar toolbar;
    RecyclerView recyclerView;
    RSSObject rssObject;

    //RSS link
    public  String RSS_link="http://rss.nytimes.com/services/xml/rss/nyt/Arts.xml";
    private final String RSS_to_Json_API = "https://api.rss2json.com/v1/api.json?rss_url=";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        toolbar = (Toolbar)findViewById(R.id.toolbar);
        toolbar.setTitle("News");
        setSupportActionBar(toolbar);
        //Create a new recyclerview
        recyclerView = (RecyclerView)findViewById(R.id.recyclerView);
        LinearLayoutManager linearLayoutManager  = new LinearLayoutManager(getBaseContext(),LinearLayoutManager.VERTICAL,false);
        recyclerView.setLayoutManager(linearLayoutManager);

        loadRSS();



    }

    private void loadRSS() {
        AsyncTask<String,String,String> loadRSSAsync = new AsyncTask<String, String, String>() {
            //Creates a new dialog
            ProgressDialog mDialog = new ProgressDialog(RSS.this);

            //Sets the dialog to say please wait
            @Override
            protected void onPreExecute() {
                mDialog.setMessage("Please wait...");
                mDialog.show();
            }
            //Create a new HTTPDataHandler to handle the HTTP request
            @Override
            protected String doInBackground(String... params) {
                String result;
                HTTPDataHandler http = new HTTPDataHandler();
                result = http.GetHTTPData(params[0]);
                return  result;
            }
            //Dismisses the dialog and creates a JSONObject which gets the data and is trun fed into the recyclerview adapter
            @Override
            protected void onPostExecute(String s) {
                mDialog.dismiss();
                rssObject = new Gson().fromJson(s,RSSObject.class);
                FeedAdapter adapter = new FeedAdapter(rssObject,getBaseContext());
                recyclerView.setAdapter(adapter);
                adapter.notifyDataSetChanged();
            }
        };

        StringBuilder url_get_data = new StringBuilder(RSS_to_Json_API);
        url_get_data.append(RSS_link);
        loadRSSAsync.execute(url_get_data.toString());
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.main_rss,menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        //Check to see if the URL had http// in it, if not it adds it
        if(item.getItemId() == R.id.menu_refresh) {
            if(RSS_link.contains("http://")) {
                loadRSS();
            }
            else{
                RSS_link = "http://" + RSS_link;
                loadRSS();
            }
        }
        if(item.getItemId() == R.id.menu_new) {
            AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(RSS.this);
            alertDialogBuilder
                    .setTitle("Options")
                    .setMessage("What would you like to do?")
                    .setPositiveButton("Change RSS Feed", new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialog, int which) {
                            LayoutInflater li = LayoutInflater.from(RSS.this);
                            View getEmpIdView = li.inflate(R.layout.get_rss, null);

                            //Create alert dialog and link to view created
                            AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(RSS.this);
                            alertDialogBuilder.setView(getEmpIdView);
                            final EditText rss = (EditText)getEmpIdView.findViewById(R.id.editText_url);

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
                                                //Try to assign the new RSS URL to the RSS_Link variable
                                                RSS_link =  rss.getText().toString();
                                                Toast.makeText(getApplicationContext(),
                                                        "RSS URL Changed", Toast.LENGTH_LONG).show();

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
        return true;
    }
}
