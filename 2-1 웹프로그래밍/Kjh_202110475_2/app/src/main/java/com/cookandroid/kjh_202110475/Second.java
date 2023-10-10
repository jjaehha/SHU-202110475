package com.cookandroid.kjh_202110475;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class Second extends Activity {
    TextView tv3, tv4, tv5, tv6, tv7, tv8;
    EditText edt3, edt4, edt5, edt6, edt7;
    Button btn4, btn5;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.second);
        tv3 = findViewById(R.id.tv3);
        tv4 = findViewById(R.id.tv4);
        tv5 = findViewById(R.id.tv5);
        tv6 = findViewById(R.id.tv6);
        tv7 = findViewById(R.id.tv7);
        tv8 = findViewById(R.id.tv8);
        edt3 = findViewById(R.id.edt3);
        edt4 = findViewById(R.id.edt4);
        edt5 = findViewById(R.id.edt5);
        edt6 = findViewById(R.id.edt6);
        edt7 = findViewById(R.id.edt7);
        btn4 = findViewById(R.id.btn4);
        btn5 = findViewById(R.id.btn5);

        btn4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (edt3.getText().length() != 0 && edt4.getText().length() != 0 && edt5.getText().length() !=0) {
                    AlertDialog.Builder dlg = new AlertDialog.Builder(Second.this);
                    dlg.setTitle(edt3.getText().toString() + "님의 회원가입을 환영합니다. \n == 입력한 정보 ==");
                    dlg.setMessage("- 학번 : " + edt4.getText().toString() + "\n- 이메일 : " + edt6.getText().toString() + "\n- 전화번호 : " +edt7.getText().toString());
                    dlg.setPositiveButton("확인", new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialogInterface, int i) {
                            Intent intent = new Intent(getApplicationContext(),MainActivity.class);
                            intent.putExtra("num1", edt3.getText().toString());
                            intent.putExtra("num2", edt4.getText().toString());
                            intent.putExtra("num3", edt5.getText().toString());
                            startActivity(intent);


                        }
                    });
                    dlg.setNegativeButton("취소", null);
                    dlg.show();
                }
            }
        });
        btn5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                edt3.setText("");
                edt4.setText("");
                edt5.setText("");
                edt6.setText("");
                edt7.setText("");
            }
        });
    }
}
