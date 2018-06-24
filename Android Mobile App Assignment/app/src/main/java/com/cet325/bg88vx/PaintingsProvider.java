package com.cet325.bg88vx;


import android.content.ContentProvider;
import android.content.ContentUris;
import android.content.ContentValues;
import android.content.UriMatcher;
import android.database.Cursor;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;
import android.net.Uri;
import android.support.annotation.Nullable;

public class PaintingsProvider extends ContentProvider {

    //Set parameters
    private static final String AUTHORITY = "com.cet325.bg88vx";
    private static final String BASE_PATH = "paintings";
    public static final Uri CONTENT_URI = Uri.parse("content://" + AUTHORITY + "/" + BASE_PATH);

    private static final int PAINTINGS = 1;
    private static final int PAINTINGS_ID = 2;

    private static final UriMatcher uriMatcher = new UriMatcher(UriMatcher.NO_MATCH);
    static {
        uriMatcher.addURI(AUTHORITY,BASE_PATH,PAINTINGS);
        uriMatcher.addURI(AUTHORITY,BASE_PATH + "/#",PAINTINGS_ID);
    }

    private SQLiteDatabase db;

    @Override
    public boolean onCreate() {
        //Creates the database
        DBCreator helper = new DBCreator(getContext());
        db = helper.getWritableDatabase();
        return true;
    }

    @Nullable
    @Override
   //Handles a curosr query
    public Cursor query(Uri uri, String[] projection, String selection, String[] selectionArgs, String sortOrder) {
        Cursor cursor;
        switch (uriMatcher.match(uri)){
            case PAINTINGS:
                cursor = db.query(DBCreator.PAINTINGS_TABLE_NAME,DBCreator.ALL_COLUMNS,
                        selection,null,null,null,sortOrder);
                break;
            default:
                throw  new IllegalArgumentException("Unknown URI " + uri);
        }
        cursor.setNotificationUri(getContext().getContentResolver(),uri);

        return cursor;
    }

    @Nullable
    @Override
    public String getType(Uri uri) {
        switch (uriMatcher.match(uri)){
            case PAINTINGS:
                //Return the mimi type of content provider
                return "vnd.android.cursor.dir/paintings";
            default:
                throw new IllegalArgumentException("uknown URI " + uri);
        }
    }

    @Nullable
    @Override
    //Handles inserts
    public Uri insert(Uri uri, ContentValues values) {
        long id = db.insert(DBCreator.PAINTINGS_TABLE_NAME,null,values);

        if (id > 0){
            Uri _uri = ContentUris.withAppendedId(CONTENT_URI, id);
            getContext().getContentResolver().notifyChange(_uri, null);
            return _uri;
        }
        throw new SQLException("Insertion Failed for URI: " + uri);
    }

    @Override
    //Handles Deletes
    public int delete(Uri uri, String selection, String[] selectionArgs) {
        int delCount = 0;
        switch (uriMatcher.match(uri)){
            case PAINTINGS:
                delCount = db.delete(DBCreator.PAINTINGS_TABLE_NAME, selection, selectionArgs);
                break;
            default:
                throw new IllegalArgumentException("Unknown URI: " + uri);
        }
        getContext().getContentResolver().notifyChange(uri, null);
        return delCount;
    }

    @Override
    //Handles updates
    public int update(Uri uri, ContentValues values, String selection, String[] selectionArgs) {
        int updCount = 0;
        switch (uriMatcher.match(uri)){
            case PAINTINGS:
                updCount = db.update(DBCreator.PAINTINGS_TABLE_NAME,values,selection,selectionArgs);
                break;
            default:
                throw new IllegalArgumentException("Unknown URI: " + uri);
        }
        getContext().getContentResolver().notifyChange(uri,null);
        return updCount;
    }

}
