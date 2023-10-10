package chapther9;

import java.awt.*;
import javax.swing.*;
import java.awt.event.*;

public class self1 extends JFrame implements ActionListener {
	
	public self1() {
		Container c = getContentPane();
		c.setBackground(Color.gray);
		c.setLayout(new FlowLayout());
		JButton b1=new JButton("노란색");
		JButton b2=new JButton("파란색");
		JButton b3=new JButton("빨간색");
		JButton b4=new JButton("초록색");
		b1.addActionListener(this);
		b2.addActionListener(this);
		b3.addActionListener(this);
		b4.addActionListener(this);
		c.add(b1);
		c.add(b2);
		c.add(b3);
		c.add(b4);
		setSize(400,400);
		setVisible(true);
		
	}

	public static void main(String[] args) {
		new self1();
	}
	@Override
	public void actionPerformed(ActionEvent e) {
		Container c=getContentPane();
		JButton bt = (JButton)e.getSource();
		if (bt.getText().equals("노란색"));
		c.setBackground(Color.yellow);
		else if (bt.getText().equals("파란색"));
			c.setBackground(Color.blue);
		else if (bt.getText().equals("빨간색"));
			c.setBackground(Color.red);
		else {
			c.setBackground(Color.green);
			
		}
	}

}
