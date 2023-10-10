package com.cookandroid.kjh_202110475;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;

import androidx.annotation.Nullable;

public class Price5 extends Activity {
    EditText editt1, editt2, editt3;
    Button bbttnn1, bbttnn2;
    TextView ttv1, ttv2;
    String num1, num2, num3;
    Integer result, value;
    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.price5);

        editt1 = (EditText) findViewById(R.id.editt1);
        editt2 = (EditText) findViewById(R.id.editt2);
        editt3 = (EditText) findViewById(R.id.editt3);
        bbttnn1 = (Button) findViewById(R.id.bbttnn1);
        bbttnn2 = (Button) findViewById(R.id.bbttnn2);
        ttv1 = (TextView) findViewById(R.id.ttv1);
        ttv2 = (TextView) findViewById(R.id.ttv2);

        Button bbttnn3 = (Button) findViewById(R.id.bbttnn3);
        bbttnn3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

        bbttnn1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                num1 = editt1.getText().toString();
                num2 = editt2.getText().toString();
                num3 = editt3.getText().toString();
                result = Integer.parseInt(num1) + Integer.parseInt(num2) + Integer.parseInt(num3);
                value = Integer.parseInt(num1) * 15000 + Integer.parseInt(num2) * 13000 + Integer.parseInt(num3) * 9000;
                ttv1.setText("주문 개수:" + result.toString());
                ttv2.setText("주문 금액:" + value.toString());
            }
        });

        bbttnn2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                editt1.setText("");
                editt2.setText("");
                editt3.setText("");
                ttv1.setText("주문 개수:");
                ttv2.setText("주문 금액:");
            }
        });
    }
}
