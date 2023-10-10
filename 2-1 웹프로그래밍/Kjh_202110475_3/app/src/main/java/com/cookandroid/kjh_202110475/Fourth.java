package com.cookandroid.kjh_202110475;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CalendarView;
import android.widget.EditText;
import android.widget.TextView;

import androidx.annotation.NonNull;

public class Fourth extends Activity {
    Button btn12, btn13, btn14;
    CalendarView calendarView;
    TextView tv13, tv30, tv32;
    EditText edt8;
    String num4;
    Integer value10;
    int selectYear, selectMonth, selectDay;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.fourth);
        btn12 = findViewById(R.id.btn12);
        btn13 = findViewById(R.id.btn13);
        btn14 = findViewById(R.id.btn14);
        calendarView = findViewById(R.id.calendarView);
        tv13 = findViewById(R.id.tv13);
        tv30 = findViewById(R.id.tv30);
        tv32 = findViewById(R.id.tv32);
        edt8 = findViewById(R.id.edt8);

        setTitle("재하투어 예약");

        Intent in = getIntent();
        String value1 = in.getStringExtra("num1");
        Integer value2 = in.getIntExtra("num2",0);
        tv30.setText(value1);

        calendarView.setOnDateChangeListener(new CalendarView.OnDateChangeListener() {
            @Override
            public void onSelectedDayChange(@NonNull CalendarView calendarView, int i, int i1, int i2) {
                selectYear=i;
                selectMonth=i1+1;
                selectDay=i2;
            }
        });

        btn12.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                tv13.setText(selectYear + "년" + selectMonth + "월" + selectDay + "일");
            }
        });

        btn14.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                num4 = edt8.getText().toString();


                value10 = value2 * Integer.parseInt(num4);


                tv32.setText("총 금액:"+ value10.toString() +"원");

            }
        });


        btn13.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent1 = new Intent(getApplicationContext(),Fifth.class);
                intent1.putExtra("num4", value10);
                intent1.putExtra("num3", tv13.getText().toString());
                intent1.putExtra("num1", value1);
                startActivity(intent1);
            }
        });

    }
}
