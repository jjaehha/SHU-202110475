package com.cookandroid.kjh_202110475;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import androidx.annotation.Nullable;

public class Price6 extends Activity {
    EditText eeedt1, eeedt2, eeedt3;
    Button bbuutt1, bbuutt2;
    TextView tvv1, tvv2;
    String num1, num2, num3;
    Integer result, value;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.price6);

        eeedt1 = (EditText) findViewById(R.id.eeedt1);
        eeedt2 = (EditText) findViewById(R.id.eeedt2);
        eeedt3 = (EditText) findViewById(R.id.eeedt3);
        bbuutt1 = (Button) findViewById(R.id.bbuutt1);
        bbuutt2 = (Button) findViewById(R.id.bbuutt2);
        tvv1 = (TextView) findViewById(R.id.tvv1);
        tvv2 = (TextView) findViewById(R.id.tvv2);

        Button bbuutt3 = (Button) findViewById(R.id.bbuutt3);
        bbuutt3 .setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

        bbuutt1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                num1 = eeedt1.getText().toString();
                num2 = eeedt2.getText().toString();
                num3 = eeedt3.getText().toString();
                result = Integer.parseInt(num1) + Integer.parseInt(num2) + Integer.parseInt(num3);
                value = result /3;
                tvv1.setText("총점:" + result.toString());
                tvv2.setText("평균:" + value.toString());
            }
        });

        bbuutt2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                eeedt1.setText("");
                eeedt2.setText("");
                eeedt3.setText("");
                tvv1.setText("총점:");
                tvv2.setText("평균:");
            }
        });
    }
}
