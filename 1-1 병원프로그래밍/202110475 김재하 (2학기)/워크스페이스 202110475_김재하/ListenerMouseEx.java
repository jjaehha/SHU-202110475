package chapther9;

import java.awt.*;
import java.awt.event.MouseEvent;

import javax.swing.JButton;
import javax.swing.JFrame;
	
	public class ListenerMouseEx extends JFrame {
		public ListenerMouseEx() {
			setTitle("Action �̺�Ʈ ������ ����");
			setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
			Container c = getContentPane();
			c.setLayout(new FlowLayout());
			JButton btn = new JButton("Action");
			btn.setBackground(Color.yellow);
			btn.addMouseListener(new MyMouseListener());
			c.add(btn);
			
			setSize(350, 150);
			setVisible(true);
		}
		public static void main(String[] args) {
			new ListenerMouseEx();
		}
	}
	class MyMouseListener implements MouseListener {


