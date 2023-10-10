package com.cookandroid.kjh_202110475;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.widget.ImageView;
import android.widget.TextView;

public class Third extends Activity {
    TextView tv9;
    ImageView imageView2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.third);
        tv9 = (TextView) findViewById(R.id.tv9);
        imageView2 = findViewById(R.id.imageView2);

        Intent in = getIntent();
        String value = in.getStringExtra("num1");
        tv9.setText("의료정보과" + (value) + "님 환영합니다.");
    }




}
