package com.cookandroid.kjh_202110475;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

public class Third extends Activity {
    TextView tv9, tv14, tv15, tv16, tv17, tv18, tv19, tv20, tv21, tv22, tv23, tv24, tv25;
    Button btn6, btn7, btn8, btn9, btn10, btn11;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.third);
        tv9 = findViewById(R.id.tv9);
        tv14 = findViewById(R.id.tv14);
        tv15 = findViewById(R.id.tv15);
        tv16 = findViewById(R.id.tv16);
        tv17 = findViewById(R.id.tv17);
        tv18 = findViewById(R.id.tv18);
        tv19 = findViewById(R.id.tv19);
        tv20 = findViewById(R.id.tv20);
        tv21 = findViewById(R.id.tv21);
        tv22 = findViewById(R.id.tv22);
        tv23 = findViewById(R.id.tv23);
        tv24 = findViewById(R.id.tv24);
        tv25 = findViewById(R.id.tv25);
        btn6 = findViewById(R.id.btn6);
        btn7 = findViewById(R.id.btn7);
        btn8 = findViewById(R.id.btn8);
        btn9 = findViewById(R.id.btn9);
        btn10 = findViewById(R.id.btn10);
        btn11 = findViewById(R.id.btn11);


        setTitle("재하투어 여행지 선택");

        Intent in = getIntent();
        String value = in.getStringExtra("num1");
        tv9.setText((value) + "님 환영합니다.");
        btn6.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent in = new Intent(getApplicationContext(), Fourth.class);
                in.putExtra("num1", tv14.getText().toString());
                in.putExtra("num2",10000);
                startActivity(in);

            }
        });
        btn7.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent in = new Intent(getApplicationContext(), Fourth.class);
                in.putExtra("num1", tv16.getText().toString());
                in.putExtra("num2", 30000);
                startActivity(in);
            }
        });
        btn8.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent in = new Intent(getApplicationContext(), Fourth.class);
                in.putExtra("num1", tv18.getText().toString());
                in.putExtra("num2", 50000);
                startActivity(in);
            }
        });
        btn9.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent in = new Intent(getApplicationContext(), Fourth.class);
                in.putExtra("num1", tv20.getText().toString());
                in.putExtra("num2", 700000);
                startActivity(in);

            }
        });
        btn10.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent in = new Intent(getApplicationContext(), Fourth.class);
                in.putExtra("num1", tv22.getText().toString());
                in.putExtra("num2", 150000);
                startActivity(in);

            }
        });
        btn11.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent in = new Intent(getApplicationContext(), Fourth.class);
                in.putExtra("num1", tv24.getText().toString());
                in.putExtra("num2", 400000);
                startActivity(in);

            }
        });
    }




}
