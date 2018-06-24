package com.cet325.bg88vx;


import android.util.Log;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLEncoder;

public class CurrencyHttpClient {

	//Create 2 variables and store the API string in them

	private static String BASE_URLEU = "https://api.fixer.io/latest?base=EUR";
	private static String BASE_URLGBP = "https://api.fixer.io/latest?base=GBP";

	//Creates a method which trys the connection to the API and if successful pulls the information from the API
	public String getConversionDataEU() {
		HttpURLConnection con = null ;
		InputStream is = null;
		String urlString = BASE_URLEU;


		try {
			con = (HttpURLConnection) (new URL(urlString)).openConnection();
            con.setRequestMethod("GET");
			con.setDoInput(true);
            con.connect();

            int response = con.getResponseCode();
            if (response == HttpURLConnection.HTTP_OK) {
                // Let's read the response
                StringBuilder buffer = new StringBuilder();
                is = con.getInputStream();
                BufferedReader br = new BufferedReader(new InputStreamReader(is));
                String line;
                while ((line = br.readLine()) != null) {
					Log.d("JSON-line",line);
					buffer.append(line + "\r\n");
				}
					is.close();
                con.disconnect();
                Log.d("JSON",buffer.toString());
				return buffer.toString();
            }
            else {
                Log.d("HttpURLConnection","Unable to connect");
                return null;
            }

	    }
		catch(Exception e) {
			e.printStackTrace();
		}
		finally {
			try { is.close(); } catch(Exception e) {}
			try { con.disconnect(); } catch(Exception e) {}
		}

		return null;
	}

	//Creates a method which trys the connection to the API and if successful pulls the information from the API
	public String getConversionDataGBP() {
		HttpURLConnection con = null ;
		InputStream is = null;
		String urlString = BASE_URLGBP;


		try {
			con = (HttpURLConnection) (new URL(urlString)).openConnection();
			con.setRequestMethod("GET");
			con.setDoInput(true);
			con.connect();

			int response = con.getResponseCode();
			if (response == HttpURLConnection.HTTP_OK) {
				// Let's read the response
				StringBuilder buffer = new StringBuilder();
				is = con.getInputStream();
				BufferedReader br = new BufferedReader(new InputStreamReader(is));
				String line;
				while ((line = br.readLine()) != null) {
					Log.d("JSON-line",line);
					buffer.append(line + "\r\n");
				}
				is.close();
				con.disconnect();
				Log.d("JSON",buffer.toString());
				return buffer.toString();
			}
			else {
				Log.d("HttpURLConnection","Unable to connect");
				return null;
			}

		}
		catch(Exception e) {
			e.printStackTrace();
		}
		finally {
			try { is.close(); } catch(Exception e) {}
			try { con.disconnect(); } catch(Exception e) {}
		}

		return null;
	}
}
