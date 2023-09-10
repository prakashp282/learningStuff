/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if(k==0 || head == null) return head;
        
        int count =0;
        var itr = head;
        while(itr!=null){
            count++;
            itr = itr.next;
        }
        itr.next = head;
        
        k %= count;
        if(k==0) return head;

        //Actual poistion to roate from.
        k=count-k;
        itr=head;
        var newHead = head;

        int currCount =0;
        
        while(itr !=null){
            var next = itr.next;
            currCount++;
            if(currCount == k){
                newHead = next;
                itr.next =null;
            } 
            itr =next;
        }
        return newHead;
    }
}
