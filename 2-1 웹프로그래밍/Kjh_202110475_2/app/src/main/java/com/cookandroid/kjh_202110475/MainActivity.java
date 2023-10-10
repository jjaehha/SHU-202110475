package com.cookandroid.kjh_202110475;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {
    TextView tv1, tv2;
    EditText edt1, edt2;
    Button btn1, btn2, btn3;
    ImageView imageView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        tv1 = findViewById(R.id.tv1);
        tv2 = findViewById(R.id.tv2);
        edt1 = findViewById(R.id.edt1);
        edt2 = findViewById(R.id.edt2);
        btn1 = findViewById(R.id.btn1);
        btn2 = findViewById(R.id.btn2);
        btn3 = findViewById(R.id.btn3);
        imageView = findViewById(R.id.imageView);

        btn3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent in = new Intent(getApplication(), Second.class);
                startActivity(in);
            }
        });
        btn2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                edt1.setText("");
                edt2.setText("");
            }
        });
        Intent intent = getIntent();
        String value = intent.getStringExtra("num1");
        String value2 = intent.getStringExtra("num2");
        String value3 = intent.getStringExtra("num3");
        edt1.setText(value2);

        btn1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(edt2.getText().toString().equals(value3)) {
                    Intent in = new Intent(getApplicationContext(), Third.class);
                    in.putExtra("num1",value);
                    startActivity(in);
                }else {
                    Toast.makeText(getApplicationContext(), "비밀번호를 다시 입력하세요", Toast.LENGTH_SHORT).show();
                }
            }
            });
                }
            }


