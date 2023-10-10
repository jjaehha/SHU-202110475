package com.cookandroid.kjh_202110475;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import java.util.Locale;

public class Fifth extends Activity {
    TextView tv26, tv27, tv28;
    EditText edt9;
    Button btn14, btn15;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.fifth);

        tv26 = findViewById(R.id.tv26);
        tv27 = findViewById(R.id.tv27);
        tv28 = findViewById(R.id.tv28);
        edt9 = findViewById(R.id.edt9);
        btn14 = findViewById(R.id.btn14);
        btn15 = findViewById(R.id.btn15);

        Intent intent1 = getIntent();
        String value1 = intent1.getStringExtra("num1");
        Integer value10 = intent1.getIntExtra("num4",0);
        String value = intent1.getStringExtra("num3");
        tv27.setText(value1);
        tv28.setText(value10.toString());
        tv26.setText(value);

        btn15.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(edt9.getText().toString().equals(value10));
                Intent in = new Intent(getApplicationContext(), Sixth.class);
                startActivity(in);

                else {

                }

            }
        });








    }
}
