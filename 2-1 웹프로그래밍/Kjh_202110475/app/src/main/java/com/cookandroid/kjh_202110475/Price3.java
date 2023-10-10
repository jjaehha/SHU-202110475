package com.cookandroid.kjh_202110475;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.annotation.Nullable;

public class Price3 extends Activity {
    EditText ett1, ett2;
    Button buttnn1;
    Button buttnn2;
    Button buttnn3;
    String num1;
    Integer result;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.price3);

        ett1 = (EditText) findViewById(R.id.ett1);
        ett2 = (EditText) findViewById(R.id.ett2);
        buttnn1 = (Button) findViewById(R.id.buttnn1);
        buttnn2 = (Button) findViewById(R.id.buttnn2);
        buttnn3 = (Button) findViewById(R.id.buttnn3);

        Button buttnn4 = (Button) findViewById(R.id.buttnn4);
        buttnn4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

        buttnn1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                num1 = ett1.getText().toString();
                result = 2022 - Integer.parseInt(num1) + 1;
                Toast.makeText(getApplicationContext(), result.toString(), Toast.LENGTH_SHORT).show();
            }
        });
        buttnn2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                num1 = ett2.getText().toString();
                result = 2022 - Integer.parseInt(num1) + 1;
                Toast.makeText(getApplicationContext(), result.toString(), Toast.LENGTH_SHORT).show();
            }
        });
        buttnn3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                ett1.setText("");
                ett2.setText("");
            }
        });
    }
}
