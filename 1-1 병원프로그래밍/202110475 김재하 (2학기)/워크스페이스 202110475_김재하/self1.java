package chapther9;

import java.awt.*;
import javax.swing.*;
import java.awt.event.*;

public class self1 extends JFrame implements ActionListener {
	
	public self1() {
		Container c = getContentPane();
		c.setBackground(Color.gray);
		c.setLayout(new FlowLayout());
		JButton b1=new JButton("�����");
		JButton b2=new JButton("�Ķ���");
		JButton b3=new JButton("������");
		JButton b4=new JButton("�ʷϻ�");
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
		if (bt.getText().equals("�����"));
		c.setBackground(Color.yellow);
		else if (bt.getText().equals("�Ķ���"));
			c.setBackground(Color.blue);
		else if (bt.getText().equals("������"));
			c.setBackground(Color.red);
		else {
			c.setBackground(Color.green);
			
		}
	}

}
