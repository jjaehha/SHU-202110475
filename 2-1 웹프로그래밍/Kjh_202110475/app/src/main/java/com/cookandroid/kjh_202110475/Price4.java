package com.cookandroid.kjh_202110475;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.Nullable;

public class Price4 extends Activity {
    EditText eet1;
    RadioButton rdb1, rdb2;
    Button bbtn1;
    Button bbtn2;
    TextView tv1;
    Float result;
    float inputvalue;
    String num1;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.price4);

        eet1 = (EditText) findViewById(R.id.eet1);
        rdb1 = (RadioButton) findViewById(R.id.rdb1);
        rdb2 = (RadioButton) findViewById(R.id.rdb2);
        bbtn1 = (Button) findViewById(R.id.bbtn1);
        bbtn2 = (Button) findViewById(R.id.bbtn2);
        tv1 = (TextView) findViewById(R.id.tv1);

        Button bbtn3 = (Button) findViewById(R.id.bbtn3);
        bbtn3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

        bbtn1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (eet1.getText().length() != 0) {
                    if (rdb1.isChecked() == true) {
                        inputvalue = Float.parseFloat(eet1.getText().toString());
                        result = (inputvalue - 32) * 5 / 9;
                        tv1.setText("결과:" + result.toString());
                    } else {
                        inputvalue = Float.parseFloat(eet1.getText().toString());
                        result = (inputvalue * 9 / 5) + 32;
                        tv1.setText("결과:" + result.toString());
                    }
                } else {
                    Toast.makeText(getApplicationContext(), "정확한 값을 입력하세요", Toast.LENGTH_LONG).show();
                }
            }
        });

        bbtn2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                eet1.setText("");
                tv1.setText("변환결과:");
            }
        });
    }
}