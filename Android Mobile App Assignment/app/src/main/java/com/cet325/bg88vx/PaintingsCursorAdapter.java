package com.cet325.bg88vx;


import android.content.Context;
import android.database.Cursor;
import android.support.v4.widget.CursorAdapter;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import android.widget.ImageView;

public class PaintingsCursorAdapter extends CursorAdapter {


    public PaintingsCursorAdapter(Context context, Cursor c, int flags) {
        super(context, c, flags);
    }

    @Override
    public View newView(Context context, Cursor cursor, ViewGroup parent) {
        return LayoutInflater.from(context).inflate(
                R.layout.painting_list_item, parent, false);
    }

    @Override
    public void bindView(View view, Context context, Cursor cursor) {
        //Link strings to database items
        String paintTitle = cursor.getString(
                cursor.getColumnIndex(DBCreator.KEY_TITLE));
        String paintArtist = cursor.getString(
                cursor.getColumnIndex(DBCreator.KEY_ARTIST));
        String paintYear = cursor.getString(
                cursor.getColumnIndex(DBCreator.KEY_YEAR));
        String paintRoom = cursor.getString(
                cursor.getColumnIndex(DBCreator.KEY_ROOM));
        String paintRank = cursor.getString(
                cursor.getColumnIndex(DBCreator.KEY_RANK));
        String paintDesc = cursor.getString(
                cursor.getColumnIndex(DBCreator.KEY_DESCRIPTION));

        //Set text views to strings created
        TextView title = (TextView)view.findViewById(R.id.textView_title);
        TextView artist = (TextView)view.findViewById(R.id.textView_artist);
        TextView year = (TextView)view.findViewById(R.id.textView_year);
        TextView room = (TextView)view.findViewById(R.id.textView_room);
        TextView rank = (TextView)view.findViewById(R.id.textView_rank);
        TextView desc = (TextView)view.findViewById(R.id.textView_desc);
        ImageView painting  = (ImageView) view.findViewById(R.id.imageView_painting);

        title.setText(paintTitle);
        artist.setText(paintArtist);
        year.setText(paintYear);
        room.setText(paintRoom);
        rank.setText(paintRank);
        desc.setText(paintDesc);

        //Gets the image name saved in the database and looks for it in the mipmap folder and displays it in the imageview
        String image_name = cursor.getString(cursor.getColumnIndexOrThrow("image"));
        int id = context.getResources().getIdentifier("com.cet325.bg88vx:mipmap/" + image_name, null, null);
        painting.setImageResource(id);

    }

}
