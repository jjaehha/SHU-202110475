package com.cookandroid.kjh_202110475;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.annotation.Nullable;

public class Price extends Activity {
    EditText edit1, edit2;
    Button buttn1;
    Button buttn2;
    String num1,num2;
    Integer result;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.price);

        Button buttn3 = (Button) findViewById(R.id.buttn3);
        buttn3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });
        edit1 = (EditText) findViewById(R.id.edit1);
        edit2 = (EditText) findViewById(R.id.edit2);
        buttn1 = (Button) findViewById(R.id.buttn1);
        buttn2 = (Button) findViewById(R.id.buttn2);

        buttn1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
            num1=edit1.getText().toString();
            num2=edit2.getText().toString();
            result= Integer.parseInt(num1)*Integer.parseInt(num2);
                Toast.makeText(getApplicationContext(),result.toString(),Toast.LENGTH_SHORT).show();
            }
        });
        buttn2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                edit1.setText("");
                edit2.setText("");

            }
        });
    }
}