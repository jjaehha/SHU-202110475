package chapther9;

import java.awt.*;
import javax.swing.*;
import java.awt.event.*;

public class self extends JFrame{
	public self() {
		Container c = getContentPane();
		c.setLayout(new FlowLayout());
		JButton b1 = new JButton("노란색");
		JButton b2 = new JButton("파란색");
		JButton b3 = new JButton("초록색");
		b1.addActionListener(new MyAction());
		b2.addActionListener(new MyAction());
		b3.addActionListener(new MyAction());
		c.add(b1);
		c.add(b2);
		c.add(b3);
		setSize(300, 300);
		setVisible(true);
	}

	public static void main(String[] args) {
		new self();
	}
}

class MyAction implements ActionListener {

	@Override
	public void actionPerformed(ActionEvent e) {
		JButton bt =(JButton)e.getSource();
		if(bt.getText().equals("노란색"))
			new yel();
		else if(bt.getText().equals("파란색"));
			new  blu();
			new green();
		
	}
	
}

class yel extends JFrame{
	yel(){
		Container c=getContentPane();
		c.setBackground(Color.yellow);
		setSize(500, 500);
		setVisible(true);
	}
}

class blu extends JFrame{
	blu(){
		Container c=getContentPane();
		c.setBackground(Color.blue);
		setSize(500, 500);
		setVisible(true);
	}
}


class green extends JFrame{
	green(){
		Container c=getContentPane();
		c.setBackground(Color.green);
		setSize(500, 500);
		setVisible(true);
	}
}