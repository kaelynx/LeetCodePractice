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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int sum = 0;
        int carryOver = 0;
        ListNode prev = null;
        ListNode temp = null;
        ListNode curr = null;
        while(l1 != null || l2 != null) {
            var lOne = (l1?.val != null) ? l1.val : 0;
            var lTwo = (l2?.val != null) ? l2.val : 0;
            sum = carryOver + lOne + lTwo;
            // carry over digit
            carryOver = (sum >= 10) ? 1 : 0;
            
            sum = sum % 10;
            
            temp = new ListNode(sum);
            
            // empty, add as first
            if(curr == null){
                curr = temp;
            } 
            else {
                prev.next = temp;
            }
            
            prev = temp;
            
            // move to next node of each
            if(l1 != null) l1 = l1.next;
            if(l2 != null) l2 = l2.next;
        }
        if(carryOver > 0) temp.next = new ListNode(carryOver);
        return curr;
    }
}