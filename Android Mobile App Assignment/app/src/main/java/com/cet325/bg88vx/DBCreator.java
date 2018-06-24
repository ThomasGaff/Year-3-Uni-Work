package com.cet325.bg88vx;

import android.content.ContentValues;
import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

public class DBCreator extends SQLiteOpenHelper {
    //Creates the database and defines the tables and what columns exist in it
    private static final int DATABASE_VERSION = 1;
    private static final String DATABASE_NAME = "paintings.db";
    public static final String PAINTINGS_TABLE_NAME = "paintings";

    public static final String KEY_ID = "_id";
    public static final String KEY_TITLE = "title";
    public static final String KEY_ARTIST = "artist";
    public static final String KEY_ROOM = "room";
    public static final String KEY_DESCRIPTION = "description";
    public static final String KEY_IMAGE = "image";
    public static final String KEY_YEAR = "year";
    public static final String KEY_RANK = "rank";
    public static final String KEY_BIN = "bin";

    public static final String[] ALL_COLUMNS =
            {KEY_ID, KEY_TITLE, KEY_ARTIST, KEY_ROOM, KEY_DESCRIPTION, KEY_IMAGE, KEY_YEAR, KEY_RANK, KEY_BIN};

    private static final String CREATE_TABLE =
            "CREATE TABLE " + PAINTINGS_TABLE_NAME + " (" +
                    KEY_ID + " INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    KEY_TITLE + " TEXT, " +
                    KEY_ARTIST + " TEXT, " +
                    KEY_ROOM + " TEXT, " +
                    KEY_DESCRIPTION + " TEXT, " +
                    KEY_IMAGE + " TEXT, " +
                    KEY_YEAR + " INTEGER, " +
                    KEY_RANK +" INTEGER, " +
                    KEY_BIN + " INTERGER);";






    DBCreator(Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);

    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        //Calls the create table method and adds data into the databse if the database doesn't exist
        db.execSQL(CREATE_TABLE);
        ContentValues p = new ContentValues();
       p.put(KEY_TITLE, "A Young Woman standing at a Virginal");
        p.put(KEY_ARTIST, "Johannes Vermeer");
        p.put(KEY_ROOM, "Room 16");
        p.put(KEY_DESCRIPTION, "The richly dressed lady playing a virginal stands in a prosperous Dutch home with paintings on the wall, a marble-tiled floor, and a skirting of locally produced Delft blue and white tiles. The two paintings on the wall behind her cannot be identified with certainty. The small landscape on the left and the painting decorating the lid of the virginal resemble works by Vermeer’s Delft colleague Pieter Groenewegen.");
        p.put(KEY_IMAGE, "aywsv");
        p.put(KEY_YEAR, 1682);
        p.put(KEY_RANK, 0);
        p.put(KEY_BIN, 0);
       db.insert(PAINTINGS_TABLE_NAME, null, p);
        p.clear();
        p.put(KEY_TITLE, "Bacchus and Ariadne");
        p.put(KEY_ARTIST, "Titian");
        p.put(KEY_ROOM, "Room 2");
        p.put(KEY_DESCRIPTION, "Bacchus, god of wine, emerges with his followers from the landscape to the right. Falling in love with Ariadne on sight, he leaps from his chariot, drawn by two cheetahs, towards her. Ariadne had been abandoned on the Greek island of Naxos by Theseus, whose ship is shown in the distance. The picture shows her initial fear of Bacchus, but he raised her to heaven and turned her into a constellation, represented by the stars above her head.");
        p.put(KEY_IMAGE, "baa");
        p.put(KEY_YEAR, 1523);
        p.put(KEY_RANK, 0);
        p.put(KEY_BIN, 0);
        db.insert(PAINTINGS_TABLE_NAME, null, p);
        p.clear();
        p.put(KEY_TITLE, "Bathers (Les Grandes Baigneuses)");
        p.put(KEY_ARTIST, "Paul Cézanne");
        p.put(KEY_ROOM, "Room 41");
        p.put(KEY_DESCRIPTION, "Cézanne painted bathers from the 1870s onwards, including numerous compositions of male and female bathers, singly or in groups. Late in life, he painted three large-scale female bather groups. In addition to the National Gallery's painting, they are now in the Barnes Foundation, Merion, PA, and the Philadelphia Museum of Art. He seems to have been at work on all three simultaneously at the time of his death.");
        p.put(KEY_IMAGE, "b");
        p.put(KEY_YEAR, 1905);
        p.put(KEY_RANK, 0);
        p.put(KEY_BIN, 0);
        db.insert(PAINTINGS_TABLE_NAME, null, p);
        p.clear();
        p.put(KEY_TITLE, "Bathers at Asnières");
        p.put(KEY_ARTIST, "Georges Seurat");
        p.put(KEY_ROOM, "Room 43");
        p.put(KEY_DESCRIPTION, "Asnières is an industrial suburb north-west of Paris on the River Seine. The present work shows a group of young workmen taking their leisure by the river.");
        p.put(KEY_IMAGE, "ba");
        p.put(KEY_YEAR, 1884);
        p.put(KEY_RANK, 0);
        p.put(KEY_BIN, 0);
        db.insert(PAINTINGS_TABLE_NAME, null, p);
        p.clear();
        p.put(KEY_TITLE, "Bathers at La Grenouillère");
        p.put(KEY_ARTIST, "Claude Monet");
        p.put(KEY_ROOM, "Room 44");
        p.put(KEY_DESCRIPTION, "This painting depicts a popular boating and bathing establishment with an adjacent floating café, on the Seine near Bougival to the west of Paris. In the summer of 1869 Monet was living near La Grenouillère with his mistress, Camille, and their son. Working alongside Renoir, he painted sketches of the scene in a very fresh and direct manner, possibly in preparation for a slightly larger canvas, now lost.");
        p.put(KEY_IMAGE, "blg");
        p.put(KEY_YEAR, 1869);
        p.put(KEY_RANK, 0);
        p.put(KEY_BIN, 0);
        db.insert(PAINTINGS_TABLE_NAME, null, p);
        p.clear();
        p.put(KEY_TITLE, "Doge Leonardo Loredan");
        p.put(KEY_ARTIST, "Giovanni Bellini");
        p.put(KEY_ROOM, "Room 62");
        p.put(KEY_DESCRIPTION, " ");
        p.put(KEY_IMAGE, "dll");
        p.put(KEY_YEAR, 1502);
        p.put(KEY_RANK, 0);
        p.put(KEY_BIN, 0);
        db.insert(PAINTINGS_TABLE_NAME, null, p);
        p.clear();
        p.put(KEY_TITLE, "Equestrian Portrait of Charles I");
        p.put(KEY_ARTIST, "Anthony van Dyck");
        p.put(KEY_ROOM, "Room 1");
        p.put(KEY_DESCRIPTION, "In 1625, King Charles I (1600 - 1649) succeeded his father James I as king of Great Britain and Ireland. Van Dyck became his court painter in 1632, and created images of him which expressed the king's belief in his divine right to govern.");
        p.put(KEY_IMAGE, "epc");
        p.put(KEY_YEAR, 1638);
        p.put(KEY_RANK, 0);
        p.put(KEY_BIN, 0);
        db.insert(PAINTINGS_TABLE_NAME, null, p);
        p.clear();
        p.put(KEY_TITLE, "Madame de Pompadour at her Tambour Frame");
        p.put(KEY_ARTIST, "François-Hubert Drouais");
        p.put(KEY_ROOM, "Room 33");
        p.put(KEY_DESCRIPTION, "The painting shows the one-time mistress of Louis XV in the last year of her life. Born Jeanne-Antoinette Poisson in 1721, she married in 1741 and became royal mistress and Marquise de Pompadour four years later. She was a patron of the arts and letters and a leader of fashion who exercised considerable influence on the public policy of France.");
        p.put(KEY_IMAGE, "mdp");
        p.put(KEY_YEAR, 1764);
        p.put(KEY_RANK, 0);
        p.put(KEY_BIN, 0);
        db.insert(PAINTINGS_TABLE_NAME, null, p);
        p.clear();
        p.put(KEY_TITLE, "Madame Moitessier");
        p.put(KEY_ARTIST, "Jean-Auguste-Dominique Ingres");
        p.put(KEY_ROOM, "Room 45");
        p.put(KEY_DESCRIPTION, "Marie-Clotilde-Inès de Foucauld was born in 1821 and married Sigisbert Moitessier, a wealthy banker, in 1842. The portrait is influenced by the art of antiquity and the Renaissance. The pose, with the hand touching the cheek, is derived from an ancient Roman fresco of a goddess, from Herculaneum. This may suggest that for Ingres Madam Moitessier represented the ideal of classical beauty. The National Gallery's 'Portrait of a Lady' by Titian may have inspired him to add the profile in the mirror.");
        p.put(KEY_IMAGE, "mm");
        p.put(KEY_YEAR, 1856);
        p.put(KEY_RANK, 0);
        p.put(KEY_BIN, 0);
        db.insert(PAINTINGS_TABLE_NAME, null, p);
        p.clear();
        p.put(KEY_TITLE, "Mr and Mrs Andrews");
        p.put(KEY_ARTIST, "Thomas Gainsborough");
        p.put(KEY_ROOM, "Room 35");
        p.put(KEY_DESCRIPTION, "This portrait is the masterpiece of Gainsborough's early years. It was painted after his return home from London to Suffolk in 1748, soon after the marriage of Robert Andrews of the Auberies and Frances Carter of Ballingdon House, near Sudbury, in November of that year.");
        p.put(KEY_IMAGE, "mma");
        p.put(KEY_YEAR, 1750);
        p.put(KEY_RANK, 0);
        p.put(KEY_BIN, 0);
        db.insert(PAINTINGS_TABLE_NAME, null, p);
        p.clear();

        Log.d("database created", db.getPath().toString());
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        //Drop older paintings table if existed
        db.execSQL("DROP TABLE IF EXISTS " + PAINTINGS_TABLE_NAME);

        //Create fresh paintings table
        this.onCreate(db);
    }
}