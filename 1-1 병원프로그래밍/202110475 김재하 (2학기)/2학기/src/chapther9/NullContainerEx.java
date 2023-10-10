package chapther9;

import javax.swing.*;
import java.awt.*;

public class NullContainerEx extends JFrame {
	public NullContainerEx() {
		setTitle("Nell Container Sample"); // �������� Ÿ��Ʋ �ޱ�
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); // ������ �����츦 ������ ���α׷� ����
		Container c = getContentPane();
		c.setLayout(null); // ����Ʈ���� ��ġ������ ����
		
		// JLabel ������Ʈ �����ϰ� ��ġ�� ũ�⸦ ���� �����Ѵ�.
		JLabel la = new JLabel("Hello, Press Buttons!");
		la.setLocation(130, 50); // la�� (130,50) ��ġ�� ����
		la.setSize(200, 20); // la�� 200x20 ũŰ�� ����
		c.add(la); // la�� ����Ʈ�ҿ� ����
		
		// 9���� ��ư ������Ʈ�� �����ϰ� ��� ������ ũ��� �����Ѵ�.
		// ��ġ�� ���� �ٸ��� ����
		for(int i=1; i<=9; i++) {
			JButton b = new JButton(Integer.toString(i)); // ��ư ����
			b.setLocation(i*20, i*20); // ��ư�� ��ġ ����
			b.setSize(50, 20); // 9 ���� ��ư ũ��� �����ϰ� 50x20
			c.add(b); // ��ư�� ����Ʈ�ҿ� ����
		}
		setSize(300, 200);
		setVisible(true);
	}

	public static void main(String[] args) {
		new NullContainerEx();

	}

}
