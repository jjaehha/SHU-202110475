package chapther9;
import java.awt.*;
import javax.swing.*;
import java.awt.event.*;
public class test_1 extends JFrame {
	public test_1() {
		setTitle("½º½º·Î ÄÚµù");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		Container c=getContentPane();
		c.setLayout(new FlowLayout());
		JButton b=new JButton("»ùÇÃ");
		b.addActionListener(null);
		c.add(b);
		setSize(200, 200);
		setVisible(true);
	}
	class MyAction implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			JButton bt =(JButton)e.getSource();
			if (bt.getText().equals("»ùÇÃ"));
			
		}
		
	}
	
class frame_1 extends JFrame{
	public frame_1() {
		setTitle("³ì»öÃ¢");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		Container c=getContentPane(;)c.setBackground(Color.green);
		setSize(500,500);
		setVisible(true);
	}
}
	public static void main(String[] args) {
		

	}

}
