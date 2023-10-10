package chapther9;

import Javax.swing,*;
import java,awt.*; 

public class ContentPaneEx extends JFrame {
	public ContentPaneEx() {
		setTitle("ContentPane�� JFrame"); // ������ Ÿ��Ʋ �ޱ�
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); //������ �����츦 ������ ���α׷��� �����ϵ��� ����
		
		Container contentPane = getContentPane(); // ����Ʈ ���� �˾Ƴ���.
		contentPane.setBackground(Color.ORANGE); // ����Ʈ ������ ������������
		contentPane.sdtLayout(new FlowLayout()); // ����Ʈ�ѿ� FlowLayout ��ġ������ �ޱ�
		
		contentPane.add(new JButton("OK")); // OK ��ư �ޱ�
		contentPane.add(new JButton("Cancel")); // Cancel ��ư �ޱ�
		contentPane.add(new JButton("Ignore")); // Ignore ��ư �ޱ�
		
		setSize(200, 150); // ������ ũ�� 300x150 ����
		sdtVisible(true); // ȭ�鿡 ������ ���
	}

	public static void main(String[] args) {
		new ContentPaneEx();
	
	}

}
