package com.cet325.bg88vx;

import android.app.AlertDialog;
import android.app.LoaderManager;
import android.content.ContentValues;
import android.content.CursorLoader;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.Loader;
import android.database.Cursor;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.v4.widget.CursorAdapter;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.text.InputType;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;


public class ViewPaintings extends AppCompatActivity implements LoaderManager.LoaderCallbacks<Cursor>{

    private CursorAdapter cursorAdapter = null;
    private String selectedItem;
    String filter;
    String sort;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_view_paintings);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        //Create cursor adaptor
        cursorAdapter = new PaintingsCursorAdapter(this,null,0);

        //Pick up the list view and attach the cursor adaptor
        final ListView list = (ListView)findViewById(R.id.listView_paintings);
        list.setAdapter(cursorAdapter);
        getLoaderManager().initLoader(0, null, this);

        //set onlong click listener for list view
        list.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> parent, View view, final int position, long id) {

                {
                    //Get the title of the item selected
                    final Cursor cursor = (Cursor) list.getItemAtPosition(position);
                    selectedItem = cursor.getString(cursor.getColumnIndexOrThrow(DBCreator.KEY_ID));


                    //Create an alert dialog asking to update or delete
                    AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(ViewPaintings.this);
                    alertDialogBuilder
                            .setTitle("Options")
                            .setMessage("What would you like to do?")
                            .setPositiveButton("Update", new DialogInterface.OnClickListener() {
                                @Override
                                public void onClick(DialogInterface dialog, int which) {
                                    //Creates the action menu to update painting
                                    createUpdateAction(cursor);
                                }
                            })
                            .setNeutralButton("Delete", new DialogInterface.OnClickListener() {
                                @Override
                                public void onClick(DialogInterface dialog, int which) {
                                    //Create delete action
                                    createDeleteAction();
                                }
                            })
                            .setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
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
            }
        });

        list.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, final int position, long id) {

                {
                    //Get the title of the item selected
                    final Cursor cursor = (Cursor) list.getItemAtPosition(position);
                    selectedItem = cursor.getString(cursor.getColumnIndexOrThrow(DBCreator.KEY_ID));
                                    createUpdateAction(cursor);

                }




            }
        });


        FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        if (fab != null) {
            fab.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    //Creates add action
                    createAddAction();
                }
            });
        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_paintings, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            //Create an array for the dialog box options
            CharSequence colors[] = new CharSequence[] {"All", "Ranked", "Unranked", "Cancel"};

            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            builder.setTitle("Display by Rank");
            builder.setItems(colors, new DialogInterface.OnClickListener() {
                @Override
                public void onClick(DialogInterface dialog, int which) {
                   //Work out which one is chosen
                    String numberAsString = Integer.toString(which);
                    if (numberAsString == "0"){
                        //Make the Filter Variable blank
                        filter = "";
                        restartLoader();
                    }
                    else if (numberAsString == "1"){
                        //Make the filter look for anything with a rank greater than 0
                        filter = DBCreator.KEY_RANK + "> 0";
                        restartLoader();

                    }
                    else if (numberAsString == "2"){
                        //Make the filter look for anything with a rank equal to 0
                        filter = DBCreator.KEY_RANK + "= 0";
                        restartLoader();
                    }
                    else if (numberAsString == "3"){

                        Toast.makeText(getApplicationContext(),
                                "Action Cancelled", Toast.LENGTH_LONG).show();
                        return;

                    }


                }
            });
            builder.show();
        }

        if (id == R.id.action_sort) {
            //Create an array for the dialog box options
            CharSequence colors[] = new CharSequence[] {"All", "Alphabetically by Title", "Alphabetically by Title and Artist", "Rank Decreasing", "Cancel"};

            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            builder.setTitle("Sort Options");
            builder.setItems(colors, new DialogInterface.OnClickListener() {
                @Override
                public void onClick(DialogInterface dialog, int which) {
                    String numberAsString = Integer.toString(which);
                    if (numberAsString == "0"){
                        //Make the Sort Variable blank

                        sort = "";
                        restartLoader();
                    }
                    else if (numberAsString == "1"){

                        //Make the sort, sort the database by title descending
                        sort = DBCreator.KEY_TITLE + " DESC";
                        restartLoader();

                    }
                    else if (numberAsString == "2"){
                        //Make the sort, sort the database by title and artist descending
                        sort = DBCreator.KEY_ARTIST +  " DESC" + ", " + DBCreator.KEY_TITLE + " DESC";
                        restartLoader();
                    }

                    else if (numberAsString == "3"){
                        //Make the sort, sort the database by rank descending
                        sort = DBCreator.KEY_RANK + " DESC";
                        restartLoader();
                    }

                    else if (numberAsString == "4"){

                        Toast.makeText(getApplicationContext(),
                                "Action Cancelled", Toast.LENGTH_LONG).show();
                        return;

                    }


                }
            });
            builder.show();
        }


        if (id == R.id.to_store) {
            Intent intent = new Intent(this, Store.class);
            startActivity(intent);
            return true;}

        return super.onOptionsItemSelected(item);
    }

    @Override
    public Loader<Cursor> onCreateLoader(int id, Bundle args) {

       //Create a new CursorLoader
        return new CursorLoader(this, PaintingsProvider.CONTENT_URI, null, filter, null, sort);
    }

    @Override
    public void onLoadFinished(Loader<Cursor> loader, Cursor data) {
       //Provide data to Cursor adapter
        cursorAdapter.swapCursor(data);
    }

    @Override
    public void onLoaderReset(Loader<Cursor> loader) {
        cursorAdapter.swapCursor(null);
    }

    private void restartLoader() {
        getLoaderManager().restartLoader(0,null,this);
    }

    //Method to insert Painting
    public void insertPainting(String title, String artist, String year, String room, String rank, String desc){
        //Create content val and insert values
        ContentValues values = new ContentValues();
        values.put(DBCreator.KEY_TITLE, title);
        values.put(DBCreator.KEY_ARTIST, artist);
        values.put(DBCreator.KEY_YEAR, year);
        values.put(DBCreator.KEY_ROOM, room);
        values.put(DBCreator.KEY_RANK, rank);
        values.put(DBCreator.KEY_DESCRIPTION, desc);
        values.put(DBCreator.KEY_BIN, 1);

        //Link content values to insert to the database
        getContentResolver().insert(PaintingsProvider.CONTENT_URI, values);

        //Toast to confirm painting added
        Toast.makeText(this, "Created painting: " + title, Toast.LENGTH_LONG).show();
    }
    //Method to update a painting
    public void updatePainting(String title, String artist, String year, String room, String rank, String desc, String id){
        //Create content val and insert values
        ContentValues values = new ContentValues();
        values.put(DBCreator.KEY_TITLE, title);
        values.put(DBCreator.KEY_ARTIST, artist);
        values.put(DBCreator.KEY_YEAR, year);
        values.put(DBCreator.KEY_ROOM, room);
        values.put(DBCreator.KEY_RANK, rank);
        values.put(DBCreator.KEY_DESCRIPTION, desc);


            String where = "_id = " + id;

            //Link content val and selection arg to database
            getContentResolver().update(PaintingsProvider.CONTENT_URI, values, where, null);
            restartLoader();
    }

    //Actionmenu for update
    public void createUpdateAction(Cursor cursor){
        //Create a view containing the get painting details activity
        LayoutInflater li = LayoutInflater.from(ViewPaintings.this);
        View getEmpIdView;
        //Create alert dialog and link to view created
        AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(ViewPaintings.this);

        if(cursor.getInt(cursor.getColumnIndex(DBCreator.KEY_BIN)) == 0) {
            getEmpIdView = li.inflate(R.layout.get_paintingsr_details, null);
            alertDialogBuilder.setView(getEmpIdView);


            //Link edit texts to variables
            final TextView title = (TextView)getEmpIdView.findViewById(R.id.textView_title);
            final TextView artist = (TextView)getEmpIdView.findViewById(R.id.textView_artist);
            final TextView year = (TextView)getEmpIdView.findViewById(R.id.textView_year);
            final TextView room = (TextView)getEmpIdView.findViewById(R.id.textView_room);
            final EditText rank = (EditText)getEmpIdView.findViewById(R.id.editText_rankd);
            final TextView desc = (TextView)getEmpIdView.findViewById(R.id.textView_desc);
            final ImageView painting  = (ImageView) getEmpIdView.findViewById(R.id.imageView_paintings);
            year.setInputType(InputType.TYPE_CLASS_NUMBER);
            rank.setInputType(InputType.TYPE_CLASS_NUMBER);
            //Set text in edit texts to current selected painting
            title.setText(cursor.getString(cursor.getColumnIndex(
                    DBCreator.KEY_TITLE)));
            artist.setText(cursor.getString(cursor.getColumnIndex(
                    DBCreator.KEY_ARTIST)));
            year.setText(cursor.getString(cursor.getColumnIndex(
                    DBCreator.KEY_YEAR)));
            room.setText(cursor.getString(cursor.getColumnIndex(
                    DBCreator.KEY_ROOM)));
            rank.setText(cursor.getString(cursor.getColumnIndex(
                    DBCreator.KEY_RANK)));
            desc.setText(cursor.getString(cursor.getColumnIndex(
                    DBCreator.KEY_DESCRIPTION)));

            //Set's the imageview's image to the string
            String image_name = cursor.getString(cursor.getColumnIndexOrThrow("image"));
            int id = getResources().getIdentifier("com.cet325.bg88vx:mipmap/" + image_name, null, null);
            painting.setImageResource(id);



            //Set dialog message
            alertDialogBuilder
                    .setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialog, int which) {
                            Toast.makeText(getApplicationContext(),
                                    "Action Cancelled", Toast.LENGTH_LONG).show();
                        }
                    })
                    .setPositiveButton("Update", new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialog, int which) {
                            try{
                                //Try to update the painting
                                if (rank.getText().toString().equals ("1") || rank.getText().toString().equals ("2") || rank.getText().toString().equals ("3") || rank.getText().toString().equals ("4") || rank.getText().toString().equals ("5")) {
                                    updatePainting(title.getText().toString(), artist.getText().toString(),
                                            year.getText().toString(), room.getText().toString(), rank.getText().toString(), desc.getText().toString(), selectedItem);
                                    Toast.makeText(getApplicationContext(),
                                            "Painting Updated", Toast.LENGTH_LONG).show();
                                }
                                else{
                                    Toast.makeText(getApplicationContext(),
                                            "Rank has to be 1-5", Toast.LENGTH_LONG).show();


                                }

                            }catch (NumberFormatException e){
                                e.printStackTrace();
                            }catch (Exception e){
                                e.printStackTrace();
                            }
                        }
                    }).create()
                    .show();

        }
        else{
            getEmpIdView = li.inflate(R.layout.get_painting_details, null);
            alertDialogBuilder.setView(getEmpIdView);


            //Link edit texts to variables
            final EditText title = (EditText)getEmpIdView.findViewById(R.id.editText_title);
            final EditText artist = (EditText)getEmpIdView.findViewById(R.id.editText_artist);
            final EditText year = (EditText)getEmpIdView.findViewById(R.id.editText_year);
            final EditText room = (EditText)getEmpIdView.findViewById(R.id.editText_room);
            final EditText rank = (EditText)getEmpIdView.findViewById(R.id.editText_rank);
            final EditText desc = (EditText)getEmpIdView.findViewById(R.id.editText_desc);
            year.setInputType(InputType.TYPE_CLASS_NUMBER);
            rank.setInputType(InputType.TYPE_CLASS_NUMBER);

            //Set text in edit texts to current selected painting
            title.setText(cursor.getString(cursor.getColumnIndex(
                    DBCreator.KEY_TITLE)));
            artist.setText(cursor.getString(cursor.getColumnIndex(
                    DBCreator.KEY_ARTIST)));
            year.setText(cursor.getString(cursor.getColumnIndex(
                    DBCreator.KEY_YEAR)));
            room.setText(cursor.getString(cursor.getColumnIndex(
                    DBCreator.KEY_ROOM)));
            rank.setText(cursor.getString(cursor.getColumnIndex(
                    DBCreator.KEY_RANK)));
            desc.setText(cursor.getString(cursor.getColumnIndex(
                    DBCreator.KEY_DESCRIPTION)));

            //Set dialog message
            alertDialogBuilder
                    .setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialog, int which) {
                            Toast.makeText(getApplicationContext(),
                                    "Action Cancelled", Toast.LENGTH_LONG).show();
                        }
                    })
                    .setPositiveButton("Update", new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialog, int which) {
                            try{
                                //Try to update the paiting
                                updatePainting(title.getText().toString(), artist.getText().toString(),
                                        year.getText().toString(), room.getText().toString(), rank.getText().toString(), desc.getText().toString(), selectedItem);
                                Toast.makeText(getApplicationContext(),
                                        "Painting Updated", Toast.LENGTH_LONG).show();

                            }catch (NumberFormatException e){
                                e.printStackTrace();
                            }catch (Exception e){
                                e.printStackTrace();
                            }
                        }
                    }).create()
                    .show();

        }



    }







    //Actionmenu for delete
    public void createDeleteAction(){
        //Create alert dialog confirming delete
        AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(ViewPaintings.this);
        alertDialogBuilder
                .setTitle("Delete")
                .setMessage("Are you sure you want to delete?")
                .setPositiveButton("Yes", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        getContentResolver().delete(PaintingsProvider.CONTENT_URI, "_id = " +
                                selectedItem, null);
                        Toast.makeText(getApplicationContext(),
                                "Painting Deleted", Toast.LENGTH_LONG).show();
                    }
                })
                .setNegativeButton("No", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        Toast.makeText(getApplicationContext(),
                                "Action Cancelled", Toast.LENGTH_LONG).show();
                        return;
                    }
                }).create()
                .show();
    }
    //Actionmenu for add
    public void createAddAction(){
        //Create a view containing the get painting details activity
        LayoutInflater li = LayoutInflater.from(ViewPaintings.this);
        View getEmpIdView = li.inflate(R.layout.get_painting_information, null);

        //Create alert dialog and link to view created
        AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(ViewPaintings.this);
        alertDialogBuilder.setView(getEmpIdView);

        //Link edit texts to variables
        final EditText title = (EditText)getEmpIdView.findViewById(R.id.editText_title);
        final EditText artist = (EditText)getEmpIdView.findViewById(R.id.editText_artist);
        final EditText year = (EditText)getEmpIdView.findViewById(R.id.editText_year);
        final EditText room = (EditText)getEmpIdView.findViewById(R.id.editText_room);
        final EditText rank = (EditText)getEmpIdView.findViewById(R.id.editText_rank);
        final EditText desc = (EditText)getEmpIdView.findViewById(R.id.editText_desc);
        year.setInputType(InputType.TYPE_CLASS_NUMBER);
        rank.setInputType(InputType.TYPE_CLASS_NUMBER);
        rank.setText("0");
        room.setText("Room");


        //Set dialog message
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
                        try {
                            //Try to insert the Painting

                            insertPainting(title.getText().toString(), artist.getText().toString(),
                                    year.getText().toString(), room.getText().toString(), rank.getText().toString(), desc.getText().toString());
                            restartLoader();
                            Toast.makeText(getApplicationContext(),
                                    "Painting Added", Toast.LENGTH_LONG).show();
                        }catch (NumberFormatException e){
                            e.printStackTrace();
                        }catch (Exception e){
                            e.printStackTrace();
                        }

                    }
                }).create()
                .show();
    }


}